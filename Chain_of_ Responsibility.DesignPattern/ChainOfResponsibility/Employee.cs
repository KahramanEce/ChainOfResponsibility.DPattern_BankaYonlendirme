using Chain_of__Responsibility.DesignPattern.DAL;
using Chain_of__Responsibility.DesignPattern.Models;

namespace Chain_of__Responsibility.DesignPattern.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee superVisor)
        {
            this.NextApprover = superVisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
