using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TESL
{
    public static class Helpers
    {
        public static List<string> SplitByTokens(this Stream stream, char beginToken, char endToken)
        {
            var bstream = new BinaryReader(stream, Encoding.UTF8);
            var depth = 0;
            var tokens = new List<string>();
            var builder = new StringBuilder();
            while (!bstream.BaseStream.IsAtEnd())
            {
                builder.Clear();
                do
                {
                    var chr = bstream.ReadChar();
                    if (chr == beginToken)
                        depth++;
                    if(depth > 0)
                        builder.Append(chr);

                    if (chr == endToken)
                        depth--;

                } while (depth > 0);
                if(builder.Length != 0)
                    tokens.Add(builder.ToString());

            }
            return tokens;
        }

        public static bool IsAtEnd(this Stream stream)
            => stream.Length == stream.Position;

    }
}