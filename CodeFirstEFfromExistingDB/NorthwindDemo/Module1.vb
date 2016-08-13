Imports Northwind.Datalayer.Model

Module Module1

    Sub Main()

        Using dbContext As New NorthwindDbContext()

            Dim categories = dbContext.Categories

            For Each category In categories
                Console.WriteLine(category.CategoryId & " " & category.CategoryName)
            Next

            Console.WriteLine()

            Dim customerHistories = dbContext.CustOrderHist("ALFKI")

            For Each customerHistory In customerHistories
                Console.WriteLine($"{customerHistory.Total,2} {customerHistory.ProductName}")
            Next

        End Using

        Console.WriteLine("Press any key to exit....")
        Console.ReadKey()
    End Sub

End Module
