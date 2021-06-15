namespace P0
{
    public class Product : ProductBase, IProduct
    {
        // class var 
        static int quantity = 0;
        // instance var 
        // constructor
        public Product(string productName) : base(productName){}
        public Product(string productName, string productDescription, int productPrice,  bool disponibility) : base(productName, productDescription, productPrice, disponibility){
            quantity += 1;
        }
        // instance methods 
        // override methods
	    // interface methods
        public void Chosen(){
            this.Disponibility = false;
        }
        // class methods
    }
}