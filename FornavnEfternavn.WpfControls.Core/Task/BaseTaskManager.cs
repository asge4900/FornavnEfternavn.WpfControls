﻿using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using static Dna.FrameworkDI;
using Dna;

namespace FornavnEfternavn.WpfControls.Core
{
    /// <summary>
    /// Handles anything to do with Tasks
    /// </summary>
    public class BaseTaskManager : ITaskManager
    {
        #region Task Methods

        public async Task Run(Func<Task> function, [CallerMemberName]string origin = "", [CallerFilePath]string filePath = "", [CallerLineNumber]int lineNumber = 0)
        {
            try
            {
                // Try and run the task
                await Task.Run(function);
            }
            catch (Exception ex)
            {
                // Log error
                Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }


        public async void RunAndForget(Func<Task> funtion, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            await Run(funtion, origin, filePath, lineNumber);
        }


        public async Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken, [CallerMemberName]string origin = "", [CallerFilePath]string filePath = "", [CallerLineNumber]int lineNumber = 0)
        {
            try
            {
                // Try and run the task
                return await Task.Run(function, cancellationToken);
            }
            catch (Exception ex)
            {
                // Log error
                Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task<TResult> Run<TResult>(Func<Task<TResult>> function, [CallerMemberName]string origin = "", [CallerFilePath]string filePath = "", [CallerLineNumber]int lineNumber = 0)
        {
            try
            {
                // Try and run the task
                return await Task.Run(function);
            }
            catch (Exception ex)
            {
                // Log error
                Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken, [CallerMemberName]string origin = "", [CallerFilePath]string filePath = "", [CallerLineNumber]int lineNumber = 0)
        {
            try
            {
                // Try and run the task
                return await Task.Run(function, cancellationToken);
            }
            catch (Exception ex)
            {
                // Log error
                Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task<TResult> Run<TResult>(Func<TResult> function, [CallerMemberName]string origin = "", [CallerFilePath]string filePath = "", [CallerLineNumber]int lineNumber = 0)
        {
            try
            {
                // Try and run the task
                return await Task.Run(function);
            }
            catch (Exception ex)
            {
                // Log error
                Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task Run(Func<Task> function, CancellationToken cancellationToken, [CallerMemberName]string origin = "", [CallerFilePath]string filePath = "", [CallerLineNumber]int lineNumber = 0)
        {
            try
            {
                // Try and run the task
                await Task.Run(function, cancellationToken);
            }
            catch (Exception ex)
            {
                // Log error
                Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task Run(Action action, CancellationToken cancellationToken, [CallerMemberName]string origin = "", [CallerFilePath]string filePath = "", [CallerLineNumber]int lineNumber = 0)
        {
            try
            {
                // Try and run the task
                await Task.Run(action, cancellationToken);
            }
            catch (Exception ex)
            {
                // Log error
                Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task Run(Action action, [CallerMemberName]string origin = "", [CallerFilePath]string filePath = "", [CallerLineNumber]int lineNumber = 0)
        {
            try
            {
                // Try and run the task
                await Task.Run(action);
            }
            catch (Exception ex)
            {
                // Log error
                Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        #endregion

    }
}
