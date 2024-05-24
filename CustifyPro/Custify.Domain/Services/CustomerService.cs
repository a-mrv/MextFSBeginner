using Custify.Domain.Dtos;
using Custify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Custify.Domain.Services;
public class CustomerService
{
    private static List<Customer> customers = new();

    public List<Customer> GetAll()
    {
        return customers;
    }

    public void Add(Customer customer) // Will return result
    {
        customer.Id = Guid.NewGuid();
        customers.Add(customer);
    }

    public void Update(Customer customerToUpdate)

    {
        foreach (var customer in customers)
        {
            if (customer.Id == customerToUpdate.Id)
            {
                customer.Name = customerToUpdate.Name;
                customer.Email = customerToUpdate.Email;
                customer.Address = customerToUpdate.Address;
                customer.Gender = customerToUpdate.Gender;
                break;
            }
        }

        
    }
    

    public void Delete(Guid id)
    {
        foreach (var customer in customers)
        {
            if (customer.Id == id)
            {
                customers.Remove(customer);
                break;
            }
        }
    }
}
