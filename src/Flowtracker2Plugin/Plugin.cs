﻿using System.IO;
using FieldDataPluginFramework;
using FieldDataPluginFramework.Context;
using FieldDataPluginFramework.Results;

namespace FlowTracker2Plugin
{
    public class Plugin : IFieldDataPlugin
    {
        public ParseFileResult ParseFile(Stream fileStream, IFieldDataResultsAppender fieldDataResultsAppender, ILog logger)
        {
            var parser = new DataFileParser(logger, fieldDataResultsAppender);

            return parser.Parse(fileStream);
        }

        public ParseFileResult ParseFile(Stream fileStream, LocationInfo targetLocation, IFieldDataResultsAppender fieldDataResultsAppender, ILog logger)
        {
            var parser = new DataFileParser(logger, fieldDataResultsAppender);

            return parser.Parse(fileStream, targetLocation);
        }
    }
}
