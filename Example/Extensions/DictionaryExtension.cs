using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Extensions
{
    public static class DictionaryExtension
    {
        public static void AddToDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> values,
            IList<TValue> users,
            IDictionary<TKey, IList<TKey>> indexes
        )
        where TValue : IUser
        where TKey : notnull
        {
            TKey castToKey(object key)
            {
                return (TKey)key;
            };
            void addIndex(object findKeyObject, TKey dataKey)
            {
                TKey findKey = castToKey(findKeyObject);
                if (indexes.ContainsKey(findKey))
                {
                    indexes[findKey].Add(dataKey);
                }
                else
                {
                    indexes.Add(findKey, new List<TKey>() { dataKey });
                }
            };
            users?.ToList().ForEach(user =>
            {
                TKey key = castToKey(user.UserName);
                values.Add(key, user);
                addIndex(user.FirstName, key);
                addIndex(user.LastName, key);
                addIndex(user.IDNo, key);
                var personal = user.CastTo<IPersonal>();
                if (personal != null)
                {
                    addIndex(personal.SSN, key);
                    addIndex(personal.Salary.ToString(), key);

                }
                var student = user.CastTo<IStudent>();
                if (student != null)
                {
                    addIndex(student.Absenteeism, key);
                    addIndex(student.IDNo, key);
                    addIndex(student.Marks, key);

                }
                var jobber = user.CastTo<IJobber>();
                if (jobber != null)
                {
                    addIndex(jobber.PlateNo, key);
                    addIndex(jobber.WorkArea, key);

                }

            });
        }
        public static TObject? CastTo<TObject>(this object value)
            where TObject : class
        {
            if (value is TObject)
            {
                return value as TObject;
            }
            return null;
        }
    }
}
