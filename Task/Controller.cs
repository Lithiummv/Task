using System;
using System.Data.Entity;
using System.Linq;
using Task.Models;

namespace Task
{
    class Controller
    {
        private TaskContext bd;

        public Controller()
        {
            bd = new TaskContext();
        }

        public void AddOrganization(string nameOrganization, string contractNumber, DateTime contractDate)
        {
            Organization organization = new Organization
            {
                NameOrganization = nameOrganization,
                ContractNumber = contractNumber,
                ContractDate = contractDate,
            };
            bd.Organizations.Add(organization);
            bd.SaveChanges();
        }

        public void AddCar(string carBrand, string carModel, string stateRegistrationNumber, double bodyCapacity,
            Organization organization)
        {
            Car car = new Car
            {
                CarBrand = carBrand,
                CarModel = carModel,
                StateRegistrationNumber = stateRegistrationNumber,
                BodyCapacity = bodyCapacity,
                OrganizationId = organization.OrganizationId
            };
            bd.Organizations.Find(organization.OrganizationId).Cars.Add(car);
            bd.Cars.Add(car);
            bd.SaveChanges();
        }

        public void DeleteOrganization(int id)
        {
            Organization organization = bd.Organizations.Find(id);
            foreach (var car in organization.Cars.ToArray())
            {
                bd.Cars.Remove(car);
            }

            bd.Organizations.Remove(organization);
            bd.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            Car car = bd.Cars.Find(id);
            foreach (var request in car.Requests.ToArray())
            {
                bd.Requests.Remove(request);
            }

            Organization organization = bd.Organizations.Find(car.OrganizationId);
            organization.Cars.Remove(car);
            bd.Cars.Remove(car);
            bd.SaveChanges();
        }

        public void EditOrganization(int id, string nameOrganization, string contractNumber, DateTime contractDate)
        {
            Organization organization = bd.Organizations.Find(id);
            organization.NameOrganization = nameOrganization;
            organization.ContractNumber = contractNumber;
            organization.ContractDate = contractDate;
            bd.Entry(organization).State = EntityState.Modified;
            bd.SaveChanges();
        }

        public void EditCar(int id, string carBrand, string carModel, string stateRegistrationNumber,
            double bodyCapacity)
        {
            Car car = bd.Cars.Find(id);
            car.CarBrand = carBrand;
            car.CarModel = carModel;
            car.StateRegistrationNumber = stateRegistrationNumber;
            car.BodyCapacity = bodyCapacity;
            bd.Entry(car).State = EntityState.Modified;
            bd.SaveChanges();
        }

        public void AddRequest(DateTime date, DateTime time, Car car, string waybillNumber)
        {
            Request request = new Request
            {
                DateRequest = date,
                TimeRequest = time,
                WaybillNumber = waybillNumber,
                CarId = car.CarId
            };
            bd.Cars.Find(car.CarId).Requests.Add(request);
            bd.Requests.Add(request);
            bd.SaveChanges();
        }

        public void DeleteRequest(int id)
        {
            Request request = bd.Requests.Find(id);
            Car car = bd.Cars.Find(request.CarId);
            car.Requests.Remove(request);
            bd.Requests.Remove(request);
            bd.SaveChanges();
        }

        public void EditRequest(int id, DateTime date, DateTime time, Car car, string waybillNumber)
        {
            Request request = bd.Requests.Find(id);
            Car car1 = bd.Cars.Find(request.CarId);
            car1.Requests.Remove(request);
            request.DateRequest = date;
            request.TimeRequest = time;
            request.CarId = car.CarId;
            bd.Cars.Find(car.CarId).Requests.Add(request);
            request.WaybillNumber = waybillNumber;
            bd.Entry(request).State = EntityState.Modified;
            bd.SaveChanges();
        }
    }
}
