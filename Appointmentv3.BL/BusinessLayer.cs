﻿using Appointmentv3.COMMON.DTO;
using Appointmentv3.COMMON.Entities.Preset;
using Appointmentv3.COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointmentv3.DAL;

namespace Appointmentv3.BL
{
    public class BusinessLayer : IBusinessLayer
    {
        IAppointmentRepo repo = null;
        public BusinessLayer(IAppointmentRepo repo)
        {
            this.repo = repo;
        }

        public Appointment createAppointment(CreatingAppointmentDTO creatingAppointment)
        {
            throw new NotImplementedException();
        }

        public Appointment editAppointment(int appointmentID, Appointment editedAppointment)
        {
            throw new NotImplementedException();
        }

        public Appointment getAppointment(int appointmentID)
        {
            throw new NotImplementedException();
        }

        public CardDetailsDTO getCardDetailsByDoctorID(int doctorID)
        {
            throw new NotImplementedException();
        }

        public CardDetailsDTO getCardDetailsByPetID(int petID)
        {
            throw new NotImplementedException();
        }

        public CardDetailsDTO getCardDetailsForBooking(int doctorID, DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Clinic> getClinic()
        {
            throw new NotImplementedException();
        }

        public List<Medicine> getMedicine()
        {
            throw new NotImplementedException();
        }

        public List<PetIssue> getPetIssue()
        {
            throw new NotImplementedException();
        }

        public List<Symptom> getSymptom()
        {
            throw new NotImplementedException();
        }

        public List<Test> getTests()
        {
            throw new NotImplementedException();
        }
    }
}
