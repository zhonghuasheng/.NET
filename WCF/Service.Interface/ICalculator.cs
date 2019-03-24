using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    [ServiceContract(Name ="CalculatorService", Namespace ="http://www.artech.com")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double A, double B);

        [OperationContract]
        double Subtract(double A, double B);
    }
}
