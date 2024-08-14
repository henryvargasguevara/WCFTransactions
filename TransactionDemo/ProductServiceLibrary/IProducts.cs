using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProductServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IProducts
    {

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        int AddCategory(string CategoryName);



        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        int AddProducts(int CategoryId);

        
    }

   
}
