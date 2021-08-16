using OHSUploadLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OHSUploadLibrary.OHSContry
{
    public static class ValidHelper
    {

        public static void Valid(object entity, List<string> errorInfo)
        {

            if (entity == null)
            {
                return;
            }
            FieldInfo[] fi = entity.GetType().GetFields();

            string qianzhui = entity.GetType().ToString().Replace("OHSUploadLibrary.Model","");

            for (int i = 0; i < fi.Length; i++)
            {
                if (fi[i].FieldType.ToString() == "System.String")
                {
                    if (fi[i].GetCustomAttributes(true).Where(K => K.GetType() == typeof(RequiredAttribute)).Any())
                    {
                        string values = fi[i].GetValue(entity)?.ToString();
                        if (string.IsNullOrWhiteSpace(values))
                        {

                            errorInfo.Add(qianzhui + " " + fi[i].Name);

                        }
                    }
                }
                else
                {
                    object subInfo = fi[i].GetValue(entity);
                    if (subInfo != null)
                    {
                        if (subInfo.GetType().IsArray)
                        {
                            IList<object>  arraySubModel = subInfo as IList<object>;

                            for (int c = 0; c < arraySubModel.Count; c++)
                            {
                                Valid(arraySubModel[c], errorInfo);
                            }
                           

                        }
                        else
                        {
                            Valid(subInfo, errorInfo);
                        }
                    }

                    
                    

                    
                }
            }
        }
    }
}
