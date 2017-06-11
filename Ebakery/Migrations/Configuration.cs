namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Ebakery.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Ebakery.Models.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ebakery.Models.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Users.AddOrUpdate(
                x => x.Email,
                new User { Name = "Admin", IsAdmin=true, Password="1234", Email="Admin@Ebakery.gr", StreetName="asd",
                 StreetNumber="11", Surname="Admin", Telephone="1234567899", ZipCode="12345"});


      context.Products.AddOrUpdate(
          x => x.Name, new Product { Name = "Esspresso", Price = 1.20M, Category = "������� - ��������" },
                new Product { Name = "Esspresso ������", Price = 1.50M, Category = "������� - ��������" },
                new Product { Name = "Cappuccino", Price = 1.50M, Category = "������� - ��������" },
                new Product { Name = "Cappuccino ������", Price = 1.80M, Category = "������� - ��������" },
                new Product { Name = "��� ����������", Price = 1.50M, Category = "������� - ��������" },
                new Product { Name = "��������", Price = 1.50M, Category = "������� - ��������" },
                new Product { Name = "���������", Price = 1.00M, Category = "������� - ��������" },
                new Product { Name = "��������� ������", Price = 1.50M, Category = "������� - ��������" },
                new Product { Name = "Mochaccino", Price = 2.00M, Category = "������� - ��������" },
                new Product { Name = "���� ������", Price = 1.30M, Category = "������� - ��������" },
                new Product { Name = "���� ��������", Price = 1.30M, Category = "������� - ��������" },
                new Product { Name = "�������� ��������", Price = 1.80M, Category = "������� - ��������" },
                new Product { Name = "�������� bitter", Price = 1.80M, Category = "������� - ��������" },
                new Product { Name = "�������� �����", Price = 1.80M, Category = "������� - ��������" },
                new Product { Name = "Freddo Espresso", Price = 1.50M, Category = "������� - ��������" },
                new Product { Name = "Freddo Cappuccino", Price = 1.80M, Category = "������� - ��������" },
                new Product { Name = "�����", Price = 1.50M, Category = "������� - ��������" },
                new Product { Name = "Mochaccino Ice", Price = 2.00M, Category = "������� - ��������" },
                new Product { Name = "���� �������� ��������", Price = 1.80M, Category = "������� - ��������" },
                new Product { Name = "���� �������� bitter", Price = 1.80M, Category = "������� - ��������" },
                new Product { Name = "���� �������� �����", Price = 1.80M, Category = "������� - ��������" },
                new Product { Name = "Ice Tea ������", Price = 1.70M, Category = "������� - ��������" },
                new Product { Name = "Ice Tea ��������", Price = 1.70M, Category = "������� - ��������" },
                new Product { Name = "Milkshake ��������", Price = 2.50M, Category = "������� - ��������" },
                new Product { Name = "Milkshake �������", Price = 2.50M, Category = "������� - ��������" },
                new Product { Name = "Milkshake �������", Price = 2.50M, Category = "������� - ��������" },
                new Product { Name = "Milkshake �������", Price = 2.50M, Category = "������� - ��������" },
                new Product { Name = "Coca-Cola 330ml", Price = 1.20M,  Category = "����������-������" },
                new Product { Name = "Fanta ��������� 330ml", Price = 1.20M, Category = "����������-������" },
                new Product { Name = "Fanta ������ 330ml", Price = 1.20M, Category = "����������-������" },
                new Product { Name = "Sprite 330ml", Price = 1.20M, Category = "����������-������" },
                new Product { Name = "���� 330ml", Price = 1.10M, Category = "����������-������" },
                new Product { Name = "Amita ��������� 250ml", Price = 1.50M, Category = "����������-������" },
                new Product { Name = "Amita motion 250ml", Price = 1.65M, Category = "����������-������" },
                new Product { Name = "Heineken 330ml", Price = 2.20M, Category = "����������-������" },
                new Product { Name = "Amstel 330ml", Price = 2.20M, Category = "����������-������" },
                new Product { Name = "Fix 330ml", Price = 2.00M, Category = "����������-������" },
                new Product { Name = "���� 0,5Lt", Price = 0.50M, Category = "����������-������" },
                new Product { Name = "������� ����� ���������", Price = 2.50M, Category = "����������-������" },
                new Product { Name = "������� ����� ����������", Price = 3.00M, Category = "����������-������" },
                new Product { Name = "�������� ��������", Price = 1.30M, Category = "����� snacks" },
                new Product { Name = "�������� ������", Price = 1.40M, Category = "����� snacks" },
                new Product { Name = "�������� ���������", Price = 1.50M, Category = "����� snacks" },
                new Product { Name = "�������� ���������", Price = 1.40M, Category = "����� snacks" },
                new Product { Name = "��������������� ���������", Price = 1.60M, Category = "����� snacks" },
                new Product { Name = "����������", Price = 1.60M, Category = "����� snacks" },
                new Product { Name = "���������������", Price = 1.80M, Category = "����� snacks" },
                new Product { Name = "������������", Price = 1.20M, Category = "����� snacks" },
                new Product { Name = "����� ���������", Price = 1.80M, Category = "����� snacks" },
                new Product { Name = "��������", Price = 2.30M, Category = "����� snacks" },
                new Product { Name = "����� �������", Price = 2.40M, Category = "����� snacks" },
                new Product { Name = "�������� ������-����", Price = 1.90M, Category = "����� snacks" },
                new Product { Name = "�������� ������", Price = 2.50M, Category = "����� snacks" },
                new Product { Name = "�������� ���������", Price = 2.60M, Category = "����� snacks" },
                new Product { Name = "���� ������-����", Price = 1.50M, Category = "����� snacks" },
                new Product { Name = "���� ���������-����", Price = 1.50M, Category = "����� snacks" },
                new Product { Name = "�������� ������", Price = 2.50M, Category = "���� snacks" },
                new Product { Name = "�������� ���������", Price = 2.70M, Category = "���� snacks" },
                new Product { Name = "�������� ���������", Price = 2.60M, Category = "���� snacks" },
                new Product { Name = "�������� �� ����", Price = 2.80M, Category = "���� snacks" },
                new Product { Name = "������� ������", Price = 1.90M, Category = "���� snacks" },
                new Product { Name = "������� ���������", Price = 2.00M, Category = "���� snacks" },
                new Product { Name = "������� ���������", Price = 2.00M, Category = "���� snacks" },
                new Product { Name = "�������� ��������", Price = 1.30M, Category = "�����" },
                new Product { Name = "�������� �������", Price = 1.80M, Category = "�����" },
                new Product { Name = "��������", Price = 1.80M, Category = "�����" },
                new Product { Name = "��������� �� �����", Price = 1.80M, Category = "�����" },
                new Product { Name = "Donuts ��������", Price = 1.10M, Category = "�����" },
                new Product { Name = "Donuts �������", Price = 1.10M, Category = "�����" },
                new Product { Name = "Muffin ��������", Price = 1.50M, Category = "�����" },
                new Product { Name = "Muffin �������", Price = 1.50M, Category = "�����" },
                new Product { Name = "Cheesecake �������", Price = 1.90M, Category = "�����" },
                new Product { Name = "Lemon Pie", Price = 1.80M, Category = "�����" },
                new Product { Name = "����������", Price = 2.45M, Category = "�����" },
                new Product { Name = "���� ��������", Price = 2.30M, Category = "�����" },
                new Product { Name = "��������� ��������� ����� ������� 0,5Kg", Price = 0.60M, Category = "��������������" },
                new Product { Name = "��������� ��������� �� ������� 0,5Kg", Price = 0.60M, Category = "��������������" },
                new Product { Name = "��������� ������ ������� 0,5Kg", Price = 0.65M, Category = "��������������" },
                new Product { Name = "��������� ��������� 0,5Kg", Price = 0.70M, Category = "��������������" },
                new Product { Name = "��������� �� ������� 0,5Kg", Price = 0.80M, Category = "��������������" },
                new Product { Name = "������� ����� ������� 1Kg", Price = 1.10M, Category = "��������������" },
                new Product { Name = "������� �� ������� 1Kg", Price = 1.10M, Category = "��������������" },
                new Product { Name = "��������� ����������� 0,5Kg", Price = 0.70M, Category = "��������������" },
                new Product { Name = "�������� ������������", Price = 0.50M, Category = "��������������" },
                new Product { Name = "�������� ������������ ������ �������", Price = 0.60M, Category = "��������������" },
                new Product { Name = "�������� ������������ ���������", Price = 0.65M, Category = "��������������" }
                );

       context.SaveChanges();
        }
    }
}
