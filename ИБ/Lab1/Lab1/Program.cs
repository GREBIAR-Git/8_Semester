using Lab1.DataTypes.Classes;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        TestEncryption.Test(new PolybeanSquare(), "����� ������� ����� ���������");
        TestEncryption.Test(new ReshuffleByKey("����������"), "����� ������� ����� ���������");
        TestEncryption.Test(new BigramMethod("����������"), "��������������������������");
        TestEncryption.Test(new TwoTableMethod(), "����� ������� ����� ���������");
    }
}
