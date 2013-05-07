﻿using Common.Logging;
using ScriptCs.Package;

namespace ScriptCs
{
    public class ScriptServiceRoot
    {
        public ScriptServiceRoot(
            IFileSystem fileSystem,
            IPackageAssemblyResolver packageAssemblyResolver, 
            IScriptExecutor executor,
            IScriptEngine engine,
            IScriptPackResolver scriptPackResolver, 
            IPackageInstaller packageInstaller,
            ILog logger,
            IConsole console = null)
        {
            FileSystem = fileSystem;
            PackageAssemblyResolver = packageAssemblyResolver;
            Executor = executor;
            Engine = engine;
            ScriptPackResolver = scriptPackResolver;
            PackageInstaller = packageInstaller;
            Logger = logger;
            Console = console;
        }

        public IFileSystem FileSystem { get; private set; }
        public IPackageAssemblyResolver PackageAssemblyResolver { get; private set; }
        public IScriptExecutor Executor { get; private set; }
        public IScriptPackResolver ScriptPackResolver { get; private set; }
        public IPackageInstaller PackageInstaller { get; private set; }
        public ILog Logger { get; private set; }
        public IScriptEngine Engine { get; private set; }
        public IConsole Console { get; private set; }
    }
}