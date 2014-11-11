using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Cor.Pro.Model;
using Cor.Pro.IDal;
using Cor.Pro.Dal;
using Cor.Pro.IBll;
using Cor.Pro.Bll;
using System.Collections.Generic;


namespace UnitTestArchitecture
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //IEntityService _EntityService = new EntityService();
            //MVCEntity entity = new MVCEntity()
            //{
            //    ID = Guid.NewGuid(),
            //    EntityName = "Jennifer",
            //    EntityAge = 24,
            //    EntityNotes = "I'm From UnitTest;"
            //};
            //_EntityService.Add(entity);
        }

        [TestMethod]
        public void TestAddPerson()
        {
            IPersonService _PersonService = new PersonService();
            Person person = new Person()
            {
                ID = Guid.NewGuid(),
                Age = 26,
                Name = "Carrie",
                Address = "North Sea"
            };

            _PersonService.Add(person);
        }

        [TestMethod]
        public void TestAddByRespotisory()
        {
            IPersonRepository _PersonRepository = new PersonRepository();
            Person person = new Person()
            {
                ID = Guid.NewGuid(),
                Age = 28,
                Name = "Marry",
                Address = "American"
            };

            //这样无法添加数据到数据库。
            //因为在IPersonRepository中只有Add的定义而没有SaveChanges()定义
            //数据的统一提交放置到了Service层中(UnitWork设计方式)
            _PersonRepository.Add(person);

            //如果直接通过DAL层的Repository进行数据操作 需要进行手动提交
            //需要定义PersonRepository类型而不是其接口类型(IPersonRepository)
            //因为在IPersonRepository中没有SaveChanges的定义
            //PersonRepository _PersonRepository = new PersonRepository();
            //_PersonRepository.SaveChanges();//手动提交数据操作
        }


        [TestMethod]
        public void TestAddEntity()
        {
            //直接与业务服务层交互
            IPersonService _PersonService = new PersonService();
            Person person = new Person()
            {
                ID = new Guid("B5682C45-08D1-4554-AAA7-9383A3FF87A1"),
                Name = "Kobe",
                Age = 36,
                Address = "洛杉矶"
            };

            _PersonService.Add(person);
        }

        [TestMethod]
        public void TestEditEntity()
        {
            //直接与业务服务层交互
            IPersonService _PersonService = new PersonService();
            Guid id = new Guid("B5682C45-08D1-4554-AAA7-9383A3FF87A1");
            //直接把查找也测试了
            Person person = _PersonService.Fetch(p => p.ID == id);
            //修改下年龄
            person.Age = 1122;
            //更新
            _PersonService.Edit(person);
        }

        [TestMethod]
        public void TestRemoveEntity()
        {
            IPersonService _PersonService = new PersonService();
            Guid id = new Guid("B5682C45-08D1-4554-AAA7-9383A3FF87A1");

            _PersonService.Remove(new Person() { ID = id });
        }

        [TestMethod]
        public void TestFindMethod()
        {
            IPersonService _PersonService = new PersonService();
            List<Person> personList = _PersonService.FindAll()
                                                    .AsEnumerable()
                                                    .ToList<Person>();
            //foreach (Person person in personList)
            //{
            //    System.Diagnostics.Debug.WriteLine(person.Name);
            //}

            IQueryable<Person> queryAble = _PersonService.FindAll(p => p.Name == "Marry");
            List<Person> persons = queryAble.AsEnumerable<Person>().ToList<Person>();
            int count = persons.Count();
            Person targetPerson = persons[0];

            Assert.IsTrue(count > 0);
            Assert.IsNotNull(targetPerson);
        }

    }
}
