using System;
using System.Threading.Tasks;
using MainClass;
using MassTransit;

namespace Project1.Event
{
    public  class MessageSender1:IConsumer<MainClass.Project2to1>
    {
        public async Task Consume(ConsumeContext<Project2to1> context)
        {
            var item = context.Message.Name + " " + context.Message.Famili + " " + context.Message.now;
            await Console.Out.WriteLineAsync(item);
        }
    }
}