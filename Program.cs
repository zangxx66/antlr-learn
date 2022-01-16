// See https://aka.ms/new-console-template for more information
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace AntlrLearn{
    public class Program{
        public static void Main(string[] args){
            StringParserListener("");
        }

        public static void StringParserListener(string text){
            var charStream = CharStreams.fromString(text);
            var lexer = new CSharpLexer(charStream);
            var stream = new CommonTokenStream(lexer);
            var parser = new CSharpParser(stream);
            parser.BuildParseTree = true;
            var tree = parser.compilation_unit();
            var listener = new CSharpParserBaseListener();
            ParseTreeWalker.Default.Walk(listener, tree);
        }
    }
}