Imports System.Threading
Public Class threaders
    Dim WaitAllEvents(1) As AutoResetEvent
    Private Sub dowork(ByRef tarray As ArrayList)
        Dim thread1 As Thread
        Dim thread2 As Thread
        Dim thread3 As Thread
        Dim thread4 As Thread
        Dim thread5 As Thread
        Dim thread6 As Thread
        Dim thread7 As Thread
        Dim thread8 As Thread
        Dim thread9 As Thread
        Dim thread10 As Thread

        'first we create 10 threads as assign them to subs
        thread1 = New Thread(AddressOf t1)
        thread2 = New Thread(AddressOf t2)
        thread3 = New Thread(AddressOf t3)
        thread4 = New Thread(AddressOf t4)
        thread5 = New Thread(AddressOf t5)
        thread6 = New Thread(AddressOf t6)
        thread7 = New Thread(AddressOf t7)
        thread8 = New Thread(AddressOf t8)
        thread9 = New Thread(AddressOf t9)
        thread10 = New Thread(AddressOf t10)

        'Next our 10 AutoRresetEvent instances are created
        WaitAllEvents(0) = New AutoResetEvent(False)
        WaitAllEvents(1) = New AutoResetEvent(False)
        WaitAllEvents(2) = New AutoResetEvent(False)
        WaitAllEvents(3) = New AutoResetEvent(False)
        WaitAllEvents(4) = New AutoResetEvent(False)
        WaitAllEvents(5) = New AutoResetEvent(False)
        WaitAllEvents(6) = New AutoResetEvent(False)
        WaitAllEvents(7) = New AutoResetEvent(False)
        WaitAllEvents(8) = New AutoResetEvent(False)
        WaitAllEvents(9) = New AutoResetEvent(False)

        'start the threads
        thread1.Start()
        thread2.Start()
        thread3.Start()
        thread4.Start()
        thread5.Start()
        thread6.Start()
        thread7.Start()
        thread8.Start()
        thread9.Start()
        thread10.Start()

        'after starting the threads we tell the main thread to
        'wait until all instances of AutoResetEvent have become 
        'signaled with a call to Set()
        WaitHandle.WaitAll(WaitAllEvents)
        Console.WriteLine("All threads done exiting main thread")
        thread2 = Nothing
        thread1 = Nothing
    End Sub
    Private Sub t1()

        Console.WriteLine("Thread1 done")
        WaitAllEvents(0).Set() 'I’m done so signal my Event
    End Sub
    Private Sub t2()

        Console.WriteLine("Thread2 done")
        WaitAllEvents(1).Set() 'I’m done so signal my Event
    End Sub
    Private Sub t3()
        Console.WriteLine("Thread3 done")
        WaitAllEvents(2).Set() 'I’m done
    End Sub
    Private Sub t4()
        Console.WriteLine("Thread4 done")
        WaitAllEvents(3).Set() 'I’m done
    End Sub
    Private Sub t5()
        Console.WriteLine("Thread5 done")
        WaitAllEvents(4).Set() 'I’m done
    End Sub
    Private Sub t6()
        Console.WriteLine("Thread6 done")
        WaitAllEvents(5).Set() 'I’m done
    End Sub
    Private Sub t7()
        Console.WriteLine("Thread7 done")
        WaitAllEvents(6).Set() 'I’m done
    End Sub
    Private Sub t8()
        Console.WriteLine("Thread8 done")
        WaitAllEvents(7).Set() 'I’m done
    End Sub
    Private Sub t9()
        Console.WriteLine("Thread9 done")
        WaitAllEvents(8).Set() 'I’m done
    End Sub
    Private Sub t10()
        Console.WriteLine("Thread10 done")
        WaitAllEvents(9).Set() 'I’m done
    End Sub
End Class
