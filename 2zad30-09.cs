using System;

class Program
{
       static void Main() {
             Console.WriteLine("������� ����� �:"); //��������� ������ ������������ ������ ���������� ������������� ����
             double a = Double.Parse(Console.ReadLine()); //� ��������� ������� ������
             Console.WriteLine("������� ����� b:"); //��������� ������ ������������ ������ ���������� ������������� ����
             double b = Double.Parse(Console.ReadLine()); //� ��������� ������� ������
             double p; //��������� ������ ���������� ������������� ����
             p = Math.Sqrt(a * a + b * b) + a + b; //��������� ��������� �������� �������� ������
             Console.WriteLine($"�������� ����� {p}"); //����� ����������
        }
}