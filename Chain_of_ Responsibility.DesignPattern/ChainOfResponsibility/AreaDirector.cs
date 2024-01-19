using Chain_of__Responsibility.DesignPattern.DAL;
using Chain_of__Responsibility.DesignPattern.Models;

namespace Chain_of__Responsibility.DesignPattern.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Zeynep Yılmaz";
                customerProcess.Description = "Para çekme işlemi onaylandı. Müşteriye talep ettiği tutar ödendi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                

            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Zeynep Yılmaz";
                customerProcess.Description = "Para çekme tutarı bölge müdürünün günlük ödeyebileceği limiti aştığı için işlem gerçekleştirilemedi. Müşterinin günlük maksimum para çekebileceği tutar günlük 400.000 TL olup, daha fazlası için birden fazla gün şubeye gelmesi gereklidir.";
                context.CustomerProcesses.Add(customerProcess); context.SaveChanges();
                
            }
        }
    }
}
