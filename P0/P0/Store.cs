namespace P0
{
    public class Store : StoreBase, IStore
    {
        // class var 
        // instance var 
        // constructor
        public Store(string location, string storeName) : base(location, storeName){
            
        }
        // instance methods 
        // override methods
        // interface methods
        public string Inventory(){
            return "store inventory";
        }

        // class methods
    }
}