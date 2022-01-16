// See https://aka.ms/new-console-template for more information
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace AntlrLearn{
    public class Program{
        public static void Main(string[] args){
            StringParserListener("var i = 0;if(i == 0)Console.WriteLine('hello world');");
        }

        public static void StringParserListener(string text){
            // var charStream = CharStreams.fromString(text);
            // var lexer = new ruleLexer(charStream);
            // var stream = new CommonTokenStream(lexer);
            // var parser = new ruleParser(stream);
            // parser.BuildParseTree = true;
            // var tree = parser.program();
            // var extractor = new ruleBaseListener();
            // ParseTreeWalker.Default.Walk(extractor, tree);
        }
    }
}