using System;
using System.IO;
using Xunit;

namespace GradeBook.Tests
{    
    public class TypeTests
    {

        //[Fact]
        //public void Test1()
        //{
        //    var x = GetInt();
        //    SetInt(x);

        //    Assert.Equal(3, x);
        //}

        //private void SetInt(int x)
        //{
        //    x = 42;
        //}

        //private int GetInt()
        //{
        //    return 3;
        //}

        /////////////////////////////////////////////
        // 5th example
        // 
        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(out book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(out Book book, string name)
        {
            book = new Book(name);
        }

        /////////////////////////////////////////////
        // 4th example
        // book1 stored memory location, passed to object
        // in fucntion, book stored memory location
        // when we create book = new 
        // book remove old value (old memory location)
        // and contain memory locaiton of new object 
        // (new object bc new Book(name))
        // that's why book1 in orignal function does not change, 
        // cause the object that it points to does not change
        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        /////////////////////////////////////////////
        // 3rd example
        // this ex is about passing reference to function
        // book1 created pointing to object, book1 got passed to a function
        // c# rule: always pass by value
        // so in function, a copy of the memory location is created
        // in this case, it still points to the same object
        // when we modify in function, the object (through memory location) 
        // is modified
        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        /////////////////////////////////////////////
        // 2nd example
        // book1 point to Book object, book2 point to different Book object
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }
        

       /////////////////////////////////////////////
       // First example
       // book1 is a reference type, book1 contains memory location
       // book2 copy the memory location from book1
       // basically, book1 and book2 reference (point to) the same object
       [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
