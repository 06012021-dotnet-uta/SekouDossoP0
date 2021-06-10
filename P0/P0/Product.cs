namespace P0
{
    public class Product : ProductBase, IProduct
    {
        // class var 
        static int quantity = 0;
        // instance var 
        // constructor
        public Product(string productName, string productDescription, int productPrice,  bool disponibility, Store store) : base(productName, productDescription, productPrice, disponibility, store){
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