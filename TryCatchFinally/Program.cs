namespace TryCatchFinally;

public class Program
{
    public static void Main(string[] args)
    {

        bool VerifyProductValididy(int productId)
        {
            Database db = new Database();
        
            try
            {
                db.Open();
                var product = db.GetProduct(productId);

                if  (product == null)
                {
                    throw new NullReferenceException("Produto não encontrado");//throw exception when product is null
                }
                
                return product.IsValid;
            }
            catch(NullReferenceException ex){
                Console.WriteLine(ex.Message);
                throw;
            }
            finally //will always run
            {
                db.Close();
            }    
        }

        


        
    }
}