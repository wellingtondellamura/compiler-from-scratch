﻿using System;

namespace simple_translator_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lexer = new SimpleLexer("200-250");
            var parser = new SimpleParser(lexer);
            // try {
                var res = parser.Expr();
                //Console.WriteLine(parser.Output);
                Console.WriteLine(res);
            // } catch (Exception e) {
            //     Console.WriteLine("Error: "+ e.Message);
            // }
        }

        private static void TestLexer(SimpleLexer lexer)
        {
            while (lexer.HasInput)
            {
                var token = lexer.NextToken();
                Console.WriteLine("<"+token.Type+ (token.HasValue?","+token.Attribute.Value:"")+">");
            }
        }
    }
}