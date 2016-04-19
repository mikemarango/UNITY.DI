using MEF.WPF.Common;
using MEF.WPF.Models;
using MEF.WPF.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF.WPF.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerListViewModel : ViewModelBase
    {
        [ImportingConstructor]
        public CustomerListViewModel(ICustomerRepository customerRepository)
        {
            _CustomersModel = customerRepository.GetAll();
        }

        List<Customer> _CustomersModel;

        public List<Customer> CustomersModel
        {
            get { return _CustomersModel; }
        }
    }
}
