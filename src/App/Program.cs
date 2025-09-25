using System;
using System.Linq;
using App;
using App.Models;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            // Створює базу та таблиці, якщо їх ще нема
            context.Database.EnsureCreated();

            // Додаємо клієнтів
            if (!context.Customers.Any())
            {
                context.Customers.AddRange(
                    new Customer { Name = "Іван Петренко", Email = "ivan1@mail.com", Phone = "111111111" },
                    new Customer { Name = "Олена Коваль", Email = "olena2@mail.com", Phone = "222222222" },
                    new Customer { Name = "Петро Сидоренко", Email = "petro3@mail.com", Phone = "333333333" },
                    new Customer { Name = "Марія Ткаченко", Email = "maria4@mail.com", Phone = "444444444" },
                    new Customer { Name = "Сергій Шевченко", Email = "sergiy5@mail.com", Phone = "555555555" },
                    new Customer { Name = "Андрій Бондар", Email = "andriy6@mail.com", Phone = "666666666" },
                    new Customer { Name = "Юлія Савченко", Email = "yulia7@mail.com", Phone = "777777777" },
                    new Customer { Name = "Олександр Кравчук", Email = "olex8@mail.com", Phone = "888888888" },
                    new Customer { Name = "Тетяна Гончар", Email = "tanya9@mail.com", Phone = "999999999" },
                    new Customer { Name = "Володимир Лисенко", Email = "vova10@mail.com", Phone = "101010101" },
                    new Customer { Name = "Катерина Романенко", Email = "katya11@mail.com", Phone = "111111112" },
                    new Customer { Name = "Микола Поліщук", Email = "mykola12@mail.com", Phone = "121212121" },
                    new Customer { Name = "Наталія Соколенко", Email = "natalia13@mail.com", Phone = "131313131" },
                    new Customer { Name = "Дмитро Коваленко", Email = "dima14@mail.com", Phone = "141414141" },
                    new Customer { Name = "Ірина Жук", Email = "irina15@mail.com", Phone = "151515151" }
                );
                context.SaveChanges();
            }

            // Додаємо авто
            if (!context.Cars.Any())
            {
                context.Cars.AddRange(
                    new Car { Brand = "Toyota", Model = "Camry", Year = 2020, Price = 25000 },
                    new Car { Brand = "BMW", Model = "X5", Year = 2021, Price = 55000 },
                    new Car { Brand = "Audi", Model = "A6", Year = 2019, Price = 40000 },
                    new Car { Brand = "Mercedes", Model = "C200", Year = 2020, Price = 42000 },
                    new Car { Brand = "Honda", Model = "Accord", Year = 2018, Price = 22000 },
                    new Car { Brand = "Ford", Model = "Focus", Year = 2019, Price = 18000 },
                    new Car { Brand = "Volkswagen", Model = "Passat", Year = 2021, Price = 30000 },
                    new Car { Brand = "Kia", Model = "Sportage", Year = 2020, Price = 27000 },
                    new Car { Brand = "Hyundai", Model = "Tucson", Year = 2022, Price = 31000 },
                    new Car { Brand = "Mazda", Model = "CX-5", Year = 2019, Price = 28000 },
                    new Car { Brand = "Nissan", Model = "Qashqai", Year = 2021, Price = 26000 },
                    new Car { Brand = "Skoda", Model = "Octavia", Year = 2020, Price = 24000 },
                    new Car { Brand = "Peugeot", Model = "3008", Year = 2019, Price = 25000 },
                    new Car { Brand = "Renault", Model = "Megane", Year = 2021, Price = 23000 },
                    new Car { Brand = "Tesla", Model = "Model 3", Year = 2022, Price = 50000 }
                );
                context.SaveChanges();
            }

            // Додаємо покупки (зв’язки між клієнтами й авто)
            if (!context.Purchases.Any())
            {
                var customers = context.Customers.ToList();
                var cars = context.Cars.ToList();

                context.Purchases.AddRange(
                    new Purchase { CustomerId = customers[0].Id, CarId = cars[0].Id, Date = DateTime.Now.AddDays(-100) },
                    new Purchase { CustomerId = customers[1].Id, CarId = cars[1].Id, Date = DateTime.Now.AddDays(-90) },
                    new Purchase { CustomerId = customers[2].Id, CarId = cars[2].Id, Date = DateTime.Now.AddDays(-80) },
                    new Purchase { CustomerId = customers[3].Id, CarId = cars[3].Id, Date = DateTime.Now.AddDays(-70) },
                    new Purchase { CustomerId = customers[4].Id, CarId = cars[4].Id, Date = DateTime.Now.AddDays(-60) },
                    new Purchase { CustomerId = customers[5].Id, CarId = cars[5].Id, Date = DateTime.Now.AddDays(-50) },
                    new Purchase { CustomerId = customers[6].Id, CarId = cars[6].Id, Date = DateTime.Now.AddDays(-40) },
                    new Purchase { CustomerId = customers[7].Id, CarId = cars[7].Id, Date = DateTime.Now.AddDays(-30) },
                    new Purchase { CustomerId = customers[8].Id, CarId = cars[8].Id, Date = DateTime.Now.AddDays(-20) },
                    new Purchase { CustomerId = customers[9].Id, CarId = cars[9].Id, Date = DateTime.Now.AddDays(-10) },
                    new Purchase { CustomerId = customers[10].Id, CarId = cars[10].Id, Date = DateTime.Now },
                    new Purchase { CustomerId = customers[11].Id, CarId = cars[11].Id, Date = DateTime.Now },
                    new Purchase { CustomerId = customers[12].Id, CarId = cars[12].Id, Date = DateTime.Now },
                    new Purchase { CustomerId = customers[13].Id, CarId = cars[13].Id, Date = DateTime.Now },
                    new Purchase { CustomerId = customers[14].Id, CarId = cars[14].Id, Date = DateTime.Now }
                );
                context.SaveChanges();
            
    }
}

