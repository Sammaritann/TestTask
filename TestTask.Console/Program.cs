using System;
using TestTask.Struct;

namespace TestTask.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeTree A = new NodeTree("Зеленый").AddChilder(
                new Node("Синий").AddChilder(
                    new Node("Оранжевый"),
                    new Node("Желтый")
                    ),
                new Node("Красный"),
                new Node("Фиолетовый").AddChilder(
                    new Node("Голубой"))
                );

        }
    }
}
