using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DrivingLicencePCL.Extentions;
using DrivingLicencePCL.Models;

namespace DrivingLicencePCL.Services
{
    public static class C_CreateTicketsList
    {
        private static Random _Random { get; set; } = new Random();

        private static IEnumerable<TSource> Mins<TSource>(this IEnumerable<TSource> enumerable, Func<TSource, int> minBy)
        {
            IEnumerator<TSource> enumerator = enumerable.GetEnumerator();

            Dictionary<TSource, int> mins = new Dictionary<TSource, int>();

            enumerator.MoveNext();

            TSource firstMin = enumerator.Current;
            int firstMinValue = minBy(firstMin);

            do
            {
                int TMP = minBy(enumerator.Current);
                mins.Add(enumerator.Current, TMP);
                if (firstMinValue > TMP)
                {
                    firstMin = enumerator.Current;
                    firstMinValue = TMP;
                }
            } while (enumerator.MoveNext());

            return mins.Where(o => o.Value == firstMinValue).Select(o => o.Key);
        }

        private static C_Ticket GetRandomTicketUsingTopicsTicketsCounter(this List<C_Ticket> ticketsAvalaible,Dictionary<C_Topic, int> topicsTicketsCounter)
        {
            List<C_Ticket> ticketsWhereTopicTicketsCountIsLowest = null;
            List<C_Topic> minTicketsTopics = null;

            do
            {
                minTicketsTopics = topicsTicketsCounter.Mins(o => o.Value).Select(o => o.Key).ToList();

                for (int index = 0; index < minTicketsTopics.Count; index++)
                {
                    ticketsWhereTopicTicketsCountIsLowest = ticketsAvalaible.Where(o => o.Topic == minTicketsTopics[index].Id).ToList();
                    if (ticketsWhereTopicTicketsCountIsLowest.Count == 0)
                    {
                        topicsTicketsCounter.Remove(minTicketsTopics[index]);
                        minTicketsTopics.Remove(minTicketsTopics[index]);
                    }
                }
              
            } while (minTicketsTopics.Count == 0);

            C_Topic randomMinTicketsTopic = minTicketsTopics.RandomElementInList(_Random);

            return ticketsAvalaible.Where(o => o.Topic == randomMinTicketsTopic.Id).ToList().RandomElementInList(_Random);
        }

        public static List<C_Ticket> GetTicketsAccordingToSelectedTopicsAndCount(this List<C_Ticket> tickets,List<C_Topic> selectedTopics, int count)
        {
            if (tickets==null)
                throw new Exception("tickets is null");
            if (selectedTopics == null)
                throw new Exception("selectedTopics is null");
            if (tickets.Count < count)
                throw new Exception("tickets.Count is less than count");

            List<C_Ticket> ticketsCreated = new List<C_Ticket>();
            List<C_Ticket> ticketsAvalaible = new List<C_Ticket>();
            Dictionary<C_Topic, int> topicsTicketsCounter = new Dictionary<C_Topic, int>();

            foreach (var ticket in tickets)
                ticketsAvalaible.Add(ticket);

            foreach (var topic in selectedTopics)
                topicsTicketsCounter.Add(topic, 0);

            for (int i = 0; i < count; i++)
            {
                var NewTicket = ticketsAvalaible.GetRandomTicketUsingTopicsTicketsCounter(topicsTicketsCounter);

                ticketsCreated.Add(NewTicket);
                ticketsAvalaible.Remove(NewTicket);
            }

            return ticketsCreated;
        }
    }
}
