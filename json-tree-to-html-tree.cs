using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
					
public class Program
{
	private static Stack<string> stack = new Stack<string>();
	
	private static string spaces(int identation, int level) {
		string str = string.Empty;
		int len = identation * level;
		
		for (int i = 0; i < len; i++) {
			str += " ";
		}
		
		return str;
	}
	
	private static string jsonTreeToHTMLList(JObject json, int identation=4, int level = 0, string result = "") {
		// Console.WriteLine(json.ToString());
		
		
		JToken ul = json.GetValue("tag");
		
		string space = Program.spaces(identation, level);

		result += String.Format("{0}<{1}>\n", space, ul);

		stack.Push(String.Format("{0}</{1}>\n", space, ul));
		
		JToken children = json.GetValue("children");
		
		if (children is JArray)
		{
			level = level + 1;
			
			foreach (JObject child in children) {
				
				JToken li = child.GetValue("tag");
				JToken text = child.GetValue("text");
				space = Program.spaces(identation, level);
				
				if (child.ContainsKey("children")) {
					result += String.Format("{0}<{1}>{2}\n", space, li, text);
					
					stack.Push(String.Format("{0}</{1}>\n", space, li));
					
					return Program.jsonTreeToHTMLList(
						JObject.Parse(child.GetValue("children").ToString()),
						identation,
						(level + 1),
						result
					);
				} else {
					result += String.Format("{0}<{1}>{2}</{1}>\n", space, li, text);
				}
			}
		}

		foreach (string part in stack) {
			result += part;
		}
		
		return result;
	}
	
	public static void Main()
	{
		JObject rss = new JObject(
			new JProperty("tag", "ul"),
        		new JProperty("children",
         	   		new JArray(
					new JObject(
						new JProperty("tag", "li"),
						new JProperty("text", "text 1")
					),
					new JObject(
						new JProperty("tag", "li"),
						new JProperty("text", "text 2")
					),
					new JObject(
						new JProperty("tag", "li"),
						new JProperty("text", "text 3"),
						new JProperty("children",
							new JObject(
								new JProperty("tag", "ul"),
								new JProperty("children",
									new JArray(
										new JObject(
											new JProperty("tag", "li"),
											new JProperty("text", "text 3.1")
										),									
										new JObject(
											new JProperty("tag", "li"),
											new JProperty("text", "text 3.2")
										),									
										new JObject(
											new JProperty("tag", "li"),
											new JProperty("text", "text 3.3")
										)
									)
								)
							)
						)
					)
				)
			)
		);
		Console.WriteLine(Program.jsonTreeToHTMLList(rss));
	}
}
