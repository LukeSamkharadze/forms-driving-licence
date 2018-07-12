using DrivingLicencePCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicencePCL.Extentions
{
    public static class AlgorithmForIOS
    {
        static Random Random { get; set; } = new Random();

        public static TSource RandomMinBy<TSource>(this IEnumerable<TSource> enumerable, Func<TSource, int> minBy)
        {
            if (enumerable == null)
                throw new Exception("enumerable is null");

            IEnumerator<TSource> enumerator = enumerable.GetEnumerator();

            if (enumerator.MoveNext() == false)
                throw new Exception("enumerable is empty");

            TSource min = enumerator.Current;
            int minValue = minBy(min);

            do
            {
                int TMP = minBy(enumerator.Current);
                if (minValue > TMP)
                {
                    min = enumerator.Current;
                    minValue = TMP;
                }
                else if (minValue == TMP)
                    if (Random.Next(0, 2) == 0)
                    {
                        min = enumerator.Current;
                        minValue = TMP;
                    }
            } while (enumerator.MoveNext());

            return min;
        }

        public static C_Ticket GetRandomTicketUsingTopicsTicketsCounter(this List<C_Ticket> tickets,Dictionary<C_Topic, int> topicsTicketsCounter)
        {
            if (tickets == null)
                throw new Exception("tickets is null");

            if (topicsTicketsCounter == null)
                throw new Exception("topicsTicketsCounter is null");

            C_Topic randomMinimumTicketsTopic = topicsTicketsCounter.RandomMinBy(o => o.Value).Key;

            List<C_Ticket> ticketsWhereTopicTicketsCountIsLowest = tickets.Where(o => o.Topic == randomMinimumTicketsTopic.Id).ToList();

            return ticketsWhereTopicTicketsCountIsLowest.ElementAt(Random.Next(0, ticketsWhereTopicTicketsCountIsLowest.Count));
        }

        public static IEnumerable<C_Ticket> GetTicketsAccordingToSelectedTopicsAndCount(this List<C_Ticket> tickets,List<C_Topic> selectedTopics, int count)
        {
            List<C_Ticket> ticketsCreated = new List<C_Ticket>();
            Dictionary<C_Topic, int> topicsTicketsCounter = new Dictionary<C_Topic, int>();

            foreach (var topic in selectedTopics)
                topicsTicketsCounter.Add(topic, 0);

            for (int i = 0; i < count; i++)
            {
                ticketsCreated.Add(tickets.Where((o) =>
                {
                    bool flag = false;
                    foreach (var topic in selectedTopics)
                        if (o.Topic == topic.Id)
                        {
                            flag = true;
                            break;
                        }

                    if (flag == false)
                        return false;

                    foreach (var ticket in ticketsCreated)
                        if (o == ticket)
                            return false;

                    return flag;
                }).ToList()?.GetRandomTicketUsingTopicsTicketsCounter(topicsTicketsCounter));
            }
            return ticketsCreated;
        }
    }
}
