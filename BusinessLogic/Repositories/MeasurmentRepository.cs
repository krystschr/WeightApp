using System;
using System.Collections.Generic;
using BussinesLogic.Model;

namespace BussinesLogic.Repositories
{
    public class MeasurmentRepository
    {
        private List<Measurement> _measures = new List<Measurement>()
        {
            new Measurement()
            {
                ID = 1,
                Weight = 80,
                DateOfMeasurement = DateTime.Today
            },
            new Measurement()
            {
                ID = 2,
                Weight = 85,
                DateOfMeasurement = DateTime.Today.AddDays(-1)
            },
            new Measurement()
            {
                ID = 1,
                Weight = 80,
                DateOfMeasurement = DateTime.Today.AddDays(-2)
            },
            new Measurement()
            {
                ID = 1,
                Weight = 80,
                DateOfMeasurement = DateTime.Today.AddDays(-3)
            },
        };

        public List<Measurement> GetAllMeasures()
        {
            return _measures;
        }
    }
}