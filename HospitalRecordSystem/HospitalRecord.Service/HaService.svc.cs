using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using HADatabaseEntity;
using HospitalAppointment.DataAccess;
using HospitalAppointment.DataAccess.Migrations;
using HospitalAppointment.Logic;

namespace HospitalAppointment.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HrService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HrService.svc or HrService.svc.cs at the Solution Explorer and start debugging.
    public class HaService : IHaService
    {
        private readonly AppointmentBusinessLogic _appointmentBusinessLogic = new AppointmentBusinessLogic();
        private readonly DoctorBusinessLogic _doctorBusinessLogic = new DoctorBusinessLogic();
        private readonly PatientBusinessLogic _patientBusinessLogic = new PatientBusinessLogic();
        private readonly RoomBusinessLogic _roomBusinessLogic = new RoomBusinessLogic();
        private readonly SpecialtyBusinessLogic _specialtyBusinessLogic = new SpecialtyBusinessLogic();

        //-----Auth-----------------------------
        public string GetRole(Guid patientId)
        {
            throw new NotImplementedException();
        }

        public string CreateHashOnServer(string password)
        {
            return CreateHash(password);
        }

        public Patient VerefyAuth(string loggin, string password)
        {
            Patient p = _patientBusinessLogic.GetAll().FirstOrDefault(x => x.Login.Equals(loggin));
            if (p == null)
            {
                return null;
            }
            if (VerifyPassword(password, p.Hash) == true)
            {
                return p;
            }
            return null;
        }
        public Doctor VerefyAuthDoc(string loggin, string password)
        {
            Doctor doc = _doctorBusinessLogic.GetAll().FirstOrDefault(x => x.LoginD.Equals(loggin));
            if (doc == null)
            {
                return null;
            }
            if (VerifyPassword(password, doc.HashD) == true)
            {
                return doc;
            }
            return null;
        }

        //--------------------------------------------------------Auth

        public void InsertPatient(Patient patientEntity, string password)
        {
            patientEntity.Hash = CreateHash(password);
            var blP = new PatientRepository();
            blP.Insert(patientEntity);
        }

        public void InsertRoom(Room room)
        {
            _roomBusinessLogic.Insert(room);
        }

        public IQueryable<Room> GetRooms()
        {
            return _roomBusinessLogic.GetAll();
        }


        //-----Appointment----------------------------------------
        public IQueryable<Appoinment> GetAppoinments()
        {
            return _appointmentBusinessLogic.GetAll();
        }

        public IQueryable<Appoinment> GetAppoinmentsByDate(DateTime date)
        {
            return _appointmentBusinessLogic.GetAll().Where(d => d.Date.Equals(date));
        }

        public IQueryable<Appoinment> GetAppoinmentsByPatientId(Guid patientId)
        {
            return _appointmentBusinessLogic.GetAll().Where(p => p.Patient.PatientId.Equals(patientId));
        }

        public void AddAppointment(Appoinment appoinment)
        {
            _appointmentBusinessLogic.Insert(appoinment);
        }

        public void DeleteAppointmentById(Guid appoinmentId)
        {
            _appointmentBusinessLogic.DeleteById(appoinmentId);
        }

        //--------Patient-------------------------------------------
        public Patient GetPatientByAppointmentId(Guid appointmentId)
        {
            throw new NotImplementedException();
        }

        public Phone GetPhoneByPatientId(Guid patientId)
        {
            throw new NotImplementedException();
        }

        public Passport GetPassportByPatientId(Guid patientId)
        {
            throw new NotImplementedException();
        }

        public Address GetAddressByPatientId(Guid patientId)
        {
            throw new NotImplementedException();
        }

        public HistoryBook GetHistoryBookByPatientId(Guid patientId)
        {
            throw new NotImplementedException();
        }

        //------Specialty--------------
        public IQueryable<Specialty> GetSpecialties()
        {
            return _specialtyBusinessLogic.GetAll();
        }

        public Specialty GetSpecialtyByName(string specialty)
        {
            return _specialtyBusinessLogic.GetAll().FirstOrDefault(x => x.SpecialtyName.Equals(specialty));
        }

        public int GetSpecialtyIdByName(string specialty)
        {
            return _specialtyBusinessLogic.GetAll().FirstOrDefault(x => x.SpecialtyName.Equals(specialty)).SpecialtyId;
        }

        //-----Doctor-------------------
        public IQueryable<Doctor> GetDoctors()
        {
            return _doctorBusinessLogic.GetAll();
        }

        public Doctor GetDoctorById(Guid doctoId)
        {
            return _doctorBusinessLogic.GetAll().FirstOrDefault(id => id.DoctorId.Equals(doctoId));
        }

        public void AddDoctor(Doctor doctor)
        {
            _doctorBusinessLogic.Insert(doctor);
        }
        public IQueryable<Doctor> GetDoctorsBySpecialy(int specialtyId)
        {
            return _doctorBusinessLogic.GetAll().Where(s => s.Specialty.SpecialtyId.Equals(specialtyId));// .SelectMany(s => s.Specialty.SpecialtyId.Equals(specialtyId));
        }

        public void AddDoctorOnContext(Doctor doc, int spesialtyId)
        {
            _doctorBusinessLogic.AddDoctorOnContext(doc, spesialtyId);
        }

        //***********************************************************************************************************
        //***********************************************************************************************************
        //***********************************************************************************************************
        class InvalidHashException : Exception
        {
            //public InvalidHashException() { }
            public InvalidHashException(string message)
                : base(message) { }
            public InvalidHashException(string message, Exception inner)
                : base(message, inner) { }
        }

        class CannotPerformOperationException : Exception
        {
            public CannotPerformOperationException() { }
            public CannotPerformOperationException(string message)
                : base(message) { }
            public CannotPerformOperationException(string message, Exception inner)
                : base(message, inner) { }
        }

        // These constants may be changed without breaking existing hashes.
            public const int SALT_BYTES = 24;
            public const int HASH_BYTES = 18;
            public const int PBKDF2_ITERATIONS = 64000;

            // These constants define the encoding and may not be changed.
            public const int HASH_SECTIONS = 5;
            public const int HASH_ALGORITHM_INDEX = 0;
            public const int ITERATION_INDEX = 1;
            public const int HASH_SIZE_INDEX = 2;
            public const int SALT_INDEX = 3;
            public const int PBKDF2_INDEX = 4;

            public static string CreateHash(string password)
            {
                // Generate a random salt
                byte[] salt = new byte[SALT_BYTES];
                try
                {
                    using (RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider())
                    {
                        csprng.GetBytes(salt);
                    }
                }
                catch (CryptographicException ex)
                {
                    throw new CannotPerformOperationException(
                        "Random number generator not available.",
                        ex
                        );
                }
                catch (ArgumentNullException ex)
                {
                    throw new CannotPerformOperationException(
                        "Invalid argument given to random number generator.",
                        ex
                        );
                }

                byte[] hash = PBKDF2(password, salt, PBKDF2_ITERATIONS, HASH_BYTES);

                // format: algorithm:iterations:hashSize:salt:hash
                string parts = "sha1:" +
                               PBKDF2_ITERATIONS +
                               ":" +
                               hash.Length +
                               ":" +
                               Convert.ToBase64String(salt) +
                               ":" +
                               Convert.ToBase64String(hash);
                return parts;
            }

            public static bool VerifyPassword(string password, string goodHash)
            {
                char[] delimiter = { ':' };
                string[] split = goodHash.Split(delimiter);

                if (split.Length != HASH_SECTIONS)
                {
                    throw new InvalidHashException(
                        "Fields are missing from the password hash."
                        );
                }

                // We only support SHA1 with C#.
                if (split[HASH_ALGORITHM_INDEX] != "sha1")
                {
                    throw new CannotPerformOperationException(
                        "Unsupported hash type."
                        );
                }

                int iterations = 0;
                try
                {
                    iterations = Int32.Parse(split[ITERATION_INDEX]);
                }
                catch (ArgumentNullException ex)
                {
                    throw new CannotPerformOperationException(
                        "Invalid argument given to Int32.Parse",
                        ex
                        );
                }
                catch (FormatException ex)
                {
                    throw new InvalidHashException(
                        "Could not parse the iteration count as an integer.",
                        ex
                        );
                }
                catch (OverflowException ex)
                {
                    throw new InvalidHashException(
                        "The iteration count is too large to be represented.",
                        ex
                        );
                }

                if (iterations < 1)
                {
                    throw new InvalidHashException(
                        "Invalid number of iterations. Must be >= 1."
                        );
                }

                byte[] salt = null;
                try
                {
                    salt = Convert.FromBase64String(split[SALT_INDEX]);
                }
                catch (ArgumentNullException ex)
                {
                    throw new CannotPerformOperationException(
                        "Invalid argument given to Convert.FromBase64String",
                        ex
                        );
                }
                catch (FormatException ex)
                {
                    throw new InvalidHashException(
                        "Base64 decoding of salt failed.",
                        ex
                        );
                }

                byte[] hash = null;
                try
                {
                    hash = Convert.FromBase64String(split[PBKDF2_INDEX]);
                }
                catch (ArgumentNullException ex)
                {
                    throw new CannotPerformOperationException(
                        "Invalid argument given to Convert.FromBase64String",
                        ex
                        );
                }
                catch (FormatException ex)
                {
                    throw new InvalidHashException(
                        "Base64 decoding of pbkdf2 output failed.",
                        ex
                        );
                }

                int storedHashSize = 0;
                try
                {
                    storedHashSize = Int32.Parse(split[HASH_SIZE_INDEX]);
                }
                catch (ArgumentNullException ex)
                {
                    throw new CannotPerformOperationException(
                        "Invalid argument given to Int32.Parse",
                        ex
                        );
                }
                catch (FormatException ex)
                {
                    throw new InvalidHashException(
                        "Could not parse the hash size as an integer.",
                        ex
                        );
                }
                catch (OverflowException ex)
                {
                    throw new InvalidHashException(
                        "The hash size is too large to be represented.",
                        ex
                        );
                }

                if (storedHashSize != hash.Length)
                {
                    throw new InvalidHashException(
                        "Hash length doesn't match stored hash length."
                        );
                }

                byte[] testHash = PBKDF2(password, salt, iterations, hash.Length);
                return SlowEquals(hash, testHash);
            }

            private static bool SlowEquals(byte[] a, byte[] b)
            {
                uint diff = (uint)a.Length ^ (uint)b.Length;
                for (int i = 0; i < a.Length && i < b.Length; i++)
                {
                    diff |= (uint)(a[i] ^ b[i]);
                }
                return diff == 0;
            }

            private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
            {
                using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt))
                {
                    pbkdf2.IterationCount = iterations;
                    return pbkdf2.GetBytes(outputBytes);
                }
            }
    }
}
