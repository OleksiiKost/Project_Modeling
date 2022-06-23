using ProjectOptimization;


double function(double[] u)
{
    return (Math.Pow(u[0], 2) - u[0] * u[1] + Math.Pow(u[1], 2) - 2 * u[0] + 3 * u[1] - 4);
}

static double f(double u1, double u2)
{
    return (Math.Pow(u1, 2) - u1 * u2 + Math.Pow(u2, 2) - 2 * u1 + 3 * u2 - 4);
}

var GaussSeidMeth=new GaussSeidelMethod();
var resMin = GaussSeidMeth.GaussMin(f, new Point(2, 3));
Console.WriteLine($"   Gauss-Seidel Method\n   Umin= {resMin}");
Console.WriteLine($"   U1= {GaussSeidMeth.u1}, U2= {GaussSeidMeth.u2}\n\n");



var gsm = new CoordinateDescent();
double[] u = { 1, 1 };
var res = gsm.Optimize(function, u, -1000, 1000);
Console.WriteLine($"   CoordinateDescent Method\n   Umin = {res}");
Console.WriteLine($"   U1= {u[0]}, U2= {u[1]}");