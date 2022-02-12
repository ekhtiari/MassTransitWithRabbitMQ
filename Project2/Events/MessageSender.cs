using System;
using System.Threading.Tasks;
using MainClass;
using MassTransit;

namespace Project2.Events
{
    public class MessageSender2:IConsumer<Project1to2>
    {
        public async Task Consume(ConsumeContext<Project1to2> context)
        {
            var item = context.Message.Item + " "  + context.Message.Now;
            await Console.Out.WriteLineAsync(item);
        }
    }
}