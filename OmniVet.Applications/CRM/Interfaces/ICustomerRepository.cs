using OmniVet.Application.Shared;
using OmniVet.Core.CRM;

namespace OmniVet.Application.CRM.Interfaces;

//por el momento no llevara otros datos de reportes debido a diferentes cosas necesarias para eso
//tiene por defecto otros los de IRepository de cualquier manera
public interface ICustomerRepository : IRepository<Customer,int>;
    