using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        int iCode;
        String iName;


    }
    public double PayPerpiece(int quantity)
    {
        quan=quantity;
        return quantity;
    }
    public double PayPerWeight(int weight)
    {
        wght = weight;
        return weight;
    }
