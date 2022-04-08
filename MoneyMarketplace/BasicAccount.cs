using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;


namespace MoneyMarketplace
{
    internal class BasicAccount:Account,ISerializable
    {
        //Attributes
        private int overdraft;
        //Code the objects to be saved in a specific manner.
        public override void GetObjectData(SerializationInfo info, StreamingContext Context)
        {
            base.GetObjectData(info, Context);
            info.AddValue("Overdraft", overdraft);
        }
        //De-Serializer to read the code and decide it for the application
        public BasicAccount(SerializationInfo Info, StreamingContext context) : base(Info, context)
        {
            overdraft = (int)Info.GetValue("Overdraft", typeof(int));
        }

        /*___________________
         * Account          |
         * _________________|
         * -id              |
         * -account holder  |
         * -pin             |
         * -balance         |
         * -lost-transaction|
         * -----------------|
         * Gathers/setters  |
         * Constructors     |
         * -----------------|
         * Serialized       |
         * de-serialized.   |
         * _________________|
         * _________________                  
         * ========Child====|
         * Basic acconut    |
         * - overdraft      |
         * _________________|
         * =========Child===|
         * -Extended Accont |
         * Interest Raste   |
         * =================|
         */
       

        
    }
}
