decimal valorCompra, valorPago, valorTroco;

Console.WriteLine("--- Troco ---\n");

Console.Write("Valor da compra (R$)...:");
valorCompra = Convert.ToDecimal(Console.ReadLine());

Console.Write("Valor pago (R$)........: ");
valorPago = Convert.ToDecimal(Console.ReadLine());

valorTroco = valorPago - valorCompra;

Console.WriteLine($"\nTroco: {valorTroco:C}");
