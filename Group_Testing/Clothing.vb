Public Class Clothing
    'Setting the default value 
    Dim option1 As String = "topOption1"
    Dim option2 As String = "topOption2"
    Dim option3 As String = "topOption3"
    Dim option4 As String = "topOption4"
    Dim option5 As String = "topOption5"
    Dim option6 As String = "topOption6"

    Dim categorySelect As String = "top"

    Dim topEmpty As Boolean = True
    Dim bottomEmpty As Boolean = True
    Dim shoeEmpty As Boolean = True

    Dim topSelected As String = ""
    Dim bottomSelected As String = ""
    Dim shoeSelected As String = ""

    Dim topColor As String = ""
    Dim bottomColor As String = ""
    Dim shoeColor As String = ""

    Private Sub cTop_Click(sender As Object, e As EventArgs) Handles cTop.Click
        categorySelect = "top"

        option1 = "topOption1"
        option2 = "topOption2"
        option3 = "topOption3"
        option4 = "topOption4"
        option5 = "topOption5"
        option6 = "topOption6"

        'Changes all avaialbe options into "Top" categories
        cOption1.Image = Group_Testing.My.Resources.Resources.ctop1Red_1200x1200
        option1Color1.BackColor = Color.Red
        option1Color2.BackColor = Color.Gray
        cOption2.Image = Group_Testing.My.Resources.Resources.ctop2Blue_1200x1200
        option2Color1.BackColor = Color.Blue
        option2Color2.BackColor = Color.Gray
        cOption3.Image = Group_Testing.My.Resources.Resources.workInProgressIcon_1200x1200
        cOption4.Image = Group_Testing.My.Resources.Resources.workInProgressIcon_1200x1200
        cOption5.Image = Group_Testing.My.Resources.Resources.workInProgressIcon_1200x1200
        cOption6.Image = Group_Testing.My.Resources.Resources.workInProgressIcon_1200x1200
    End Sub

    Private Sub cBottom_Click(sender As Object, e As EventArgs) Handles cBottom.Click
        categorySelect = "bottom"

        option1 = "bottomOption1"
        option2 = "bottomOption2"
        option3 = "bottomOption3"
        option4 = "bottomOption4"
        option5 = "bottomOption5"
        option6 = "bottomOption6"

        'Changes all avaialbe options into "Top" categories
        cOption1.Image = Group_Testing.My.Resources.Resources.cbottom1Brown_1200x1200
        option1Color1.BackColor = Color.SaddleBrown
        option1Color2.BackColor = Color.Gray
        cOption2.Image = Group_Testing.My.Resources.Resources.cbottom2Brown_1200x1200
        option2Color1.BackColor = Color.SaddleBrown
        option2Color2.BackColor = Color.Gray
        cOption3.Image = Group_Testing.My.Resources.Resources.workInProgressIcon_1200x1200
        cOption4.Image = Group_Testing.My.Resources.Resources.workInProgressIcon_1200x1200
        cOption5.Image = Group_Testing.My.Resources.Resources.workInProgressIcon_1200x1200
        cOption6.Image = Group_Testing.My.Resources.Resources.workInProgressIcon_1200x1200
    End Sub

    Private Sub cShoe_Click(sender As Object, e As EventArgs) Handles cShoe.Click
        categorySelect = "shoe"

        option1 = "shoeOption1"
        option2 = "shoeOption2"
        option3 = "shoeOption3"
        option4 = "shoeOption4"
        option5 = "shoeOption5"
        option6 = "shoeOption6"

        'Changes all avaialbe options into "Top" categories
        cOption1.Image = Group_Testing.My.Resources.Resources.cshoe1Black_1200x1200
        option1Color1.BackColor = Color.Black
        option1Color2.BackColor = Color.White
        cOption2.Image = Group_Testing.My.Resources.Resources.cshoe2Red_1200x1200
        option2Color1.BackColor = Color.Red
        option2Color2.BackColor = Color.SaddleBrown
        cOption3.Image = Group_Testing.My.Resources.Resources.workInProgressIcon_1200x1200
        cOption4.Image = Group_Testing.My.Resources.Resources.workInProgressIcon_1200x1200
        cOption5.Image = Group_Testing.My.Resources.Resources.workInProgressIcon_1200x1200
        cOption6.Image = Group_Testing.My.Resources.Resources.workInProgressIcon_1200x1200
    End Sub

    Private Sub cOption1_Click(sender As Object, e As EventArgs) Handles cOption1.Click
        If categorySelect = "top" Then
            topSelected = "top1"
            topColor = "Red"
            If bottomEmpty = False And shoeEmpty = False Then
                'Insert the combo version with bottom and shoe
                If bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS1B_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS1B_1200x1200

                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS1W_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS1W_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS1B_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS1B_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS1W_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS1W_1200x1200


                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS2R_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS2R_1200x1200

                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS2B_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS2B_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS2R_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS2R_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS2B_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS2B_1200x1200
                End If

            ElseIf bottomEmpty = False Then
                If bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom1Brown_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom1Grey_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom2Brown_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom2Grey_1200x1200
                End If

            ElseIf shoeEmpty = False Then
                If shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe1Black_1200x1200
                ElseIf shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe1White_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe2Red_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1Red_1200x1200
            End If
            topEmpty = False

        ElseIf categorySelect = "bottom" Then
            bottomSelected = "bottom1"
            bottomColor = "Brown"
            If topEmpty = False And shoeEmpty = False Then
                If topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS1B_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS1W_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS1W_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS1W_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS1W_1200x1200


                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS2R_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS2B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS2B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS2B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS2B_1200x1200
                End If


            ElseIf topEmpty = False Then
                If topSelected = "top1" And topColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom1Brown_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyBottom1Brown_1200x1200
                ElseIf topSelected = "top2" And topColor = "Blue" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom1Brown_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyBottom1Brown_1200x1200
                End If


            ElseIf shoeEmpty = False Then
                If shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe1Black_1200x1200
                ElseIf shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe1White_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe2Red_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1Brown_1200x1200
            End If
            bottomEmpty = False

        ElseIf categorySelect = "shoe" Then
            shoeSelected = "shoe1"
            shoeColor = "Black"
            If topEmpty = False And bottomEmpty = False Then
                If topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS1B_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS1B_1200x1200


                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS1B_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS1B_1200x1200
                End If

            ElseIf topEmpty = False Then
                If topSelected = "top1" And topColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe1Black_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyShoe1Black_1200x1200
                ElseIf topSelected = "top2" And topColor = "Blue" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe1Black_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyShoe1Black_1200x1200
                End If

            ElseIf bottomEmpty = False Then
                If bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe1Black_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1GreyShoe1Black_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe1Black_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2GreyShoe1Black_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Shoe1Black_1200x1200
            End If

            shoeEmpty = False
        End If



    End Sub

    Private Sub cOption2_Click(sender As Object, e As EventArgs) Handles cOption2.Click
        If categorySelect = "top" Then
            topSelected = "top2"
            topColor = "Blue"
            If bottomEmpty = False And shoeEmpty = False Then
                'Insert the combo version with bottom and shoe
                If bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS1B_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS1B_1200x1200

                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS1W_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS1W_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS1B_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS1B_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS1W_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS1W_1200x1200


                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS2R_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS2R_1200x1200

                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS2B_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS2B_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS2R_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS2R_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS2B_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS2B_1200x1200
                End If

            ElseIf bottomEmpty = False Then
                If bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom1Brown_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom1Grey_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom2Brown_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom2Grey_1200x1200
                End If

            ElseIf shoeEmpty = False Then
                If shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe1Black_1200x1200
                ElseIf shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe1White_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe2Red_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2Blue_1200x1200
            End If
            topEmpty = False

        ElseIf categorySelect = "bottom" Then
            bottomSelected = "bottom2"
            bottomColor = "Brown"
            If topEmpty = False And shoeEmpty = False Then
                If topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS1B_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS1W_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS1W_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS1W_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS1W_1200x1200


                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS2R_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS2B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS2B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS2B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS2B_1200x1200
                End If


            ElseIf topEmpty = False Then
                If topSelected = "top1" And topColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom2Brown_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyBottom2Brown_1200x1200
                ElseIf topSelected = "top2" And topColor = "Blue" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom2Brown_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyBottom2Brown_1200x1200
                End If


            ElseIf shoeEmpty = False Then
                If shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe1Black_1200x1200
                ElseIf shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe1White_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe2Red_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2Brown_1200x1200
            End If
            bottomEmpty = False

        ElseIf categorySelect = "shoe" Then
            shoeSelected = "shoe2"
            shoeColor = "Red"
            If topEmpty = False And bottomEmpty = False Then
                If topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS2R_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS2R_1200x1200


                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS2R_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS2R_1200x1200
                End If

            ElseIf topEmpty = False Then
                If topSelected = "top1" And topColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe2Red_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyShoe2Red_1200x1200
                ElseIf topSelected = "top2" And topColor = "Blue" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe2Red_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyShoe2Red_1200x1200
                End If

            ElseIf bottomEmpty = False Then
                If bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe2Red_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1GreyShoe2Red_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe2Red_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2GreyShoe2Red_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Shoe2Red_1200x1200
            End If

            shoeEmpty = False
        End If
    End Sub

    Private Sub cOption3_Click(sender As Object, e As EventArgs) Handles cOption3.Click
        MessageBox.Show("Currently Unavailable", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub cOption4_Click(sender As Object, e As EventArgs) Handles cOption4.Click
        MessageBox.Show("Currently Unavailable", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub cOption5_Click(sender As Object, e As EventArgs) Handles cOption5.Click
        MessageBox.Show("Currently Unavailable", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub cOption6_Click(sender As Object, e As EventArgs) Handles cOption6.Click
        MessageBox.Show("Currently Unavailable", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Insert the defauly manneqiun
        cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.mannequin_1200x1200

        topEmpty = True
        bottomEmpty = True
        shoeEmpty = True
    End Sub

    Private Sub option1Color1_Click(sender As Object, e As EventArgs) Handles option1Color1.Click
        If categorySelect = "top" Then
            cOption1.Image = Group_Testing.My.Resources.Resources.ctop1Red_1200x1200
            topSelected = "top1"
            topColor = "Red"
            If bottomEmpty = False And shoeEmpty = False Then
                'Insert the combo version with bottom and shoe
                If bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS1B_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS1B_1200x1200

                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS1W_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS1W_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS1B_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS1B_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS1W_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS1W_1200x1200


                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS2R_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS2R_1200x1200

                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS2B_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS2B_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS2R_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS2R_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS2B_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS2B_1200x1200
                End If

            ElseIf bottomEmpty = False Then
                If bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom1Brown_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom1Grey_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom2Brown_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom2Grey_1200x1200
                End If

            ElseIf shoeEmpty = False Then
                If shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe1Black_1200x1200
                ElseIf shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe1White_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe2Red_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1Red_1200x1200
            End If
            topEmpty = False

        ElseIf categorySelect = "bottom" Then
            cOption1.Image = Group_Testing.My.Resources.Resources.cbottom1Brown_1200x1200
            bottomSelected = "bottom1"
            bottomColor = "Brown"
            If topEmpty = False And shoeEmpty = False Then
                If topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS1B_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS1W_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS1W_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS1W_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS1W_1200x1200


                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS2R_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS2B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS2B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS2B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS2B_1200x1200
                End If


            ElseIf topEmpty = False Then
                If topSelected = "top1" And topColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom1Brown_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyBottom1Brown_1200x1200
                ElseIf topSelected = "top2" And topColor = "Blue" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom1Brown_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyBottom1Brown_1200x1200
                End If


            ElseIf shoeEmpty = False Then
                If shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe1Black_1200x1200
                ElseIf shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe1White_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe2Red_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1Brown_1200x1200
            End If
            bottomEmpty = False

        ElseIf categorySelect = "shoe" Then
            cOption1.Image = Group_Testing.My.Resources.Resources.cshoe1Black_1200x1200
            shoeSelected = "shoe1"
            shoeColor = "Black"
            If topEmpty = False And bottomEmpty = False Then
                If topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS1B_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS1B_1200x1200


                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS1B_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS1B_1200x1200
                End If

            ElseIf topEmpty = False Then
                If topSelected = "top1" And topColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe1Black_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyShoe1Black_1200x1200
                ElseIf topSelected = "top2" And topColor = "Blue" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe1Black_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyShoe1Black_1200x1200
                End If

            ElseIf bottomEmpty = False Then
                If bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe1Black_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1GreyShoe1Black_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe1Black_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2GreyShoe1Black_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Shoe1Black_1200x1200
            End If

            shoeEmpty = False
        End If



    End Sub

    Private Sub option1Color2_Click(sender As Object, e As EventArgs) Handles option1Color2.Click
        If categorySelect = "top" Then
            cOption1.Image = Group_Testing.My.Resources.Resources.ctop1Grey_1200x1200
            topSelected = "top1"
            topColor = "Grey"
            If bottomEmpty = False And shoeEmpty = False Then
                'Insert the combo version with bottom and shoe
                If bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS1B_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS1B_1200x1200

                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS1W_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS1W_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS1B_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS1B_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS1W_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS1W_1200x1200


                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS2R_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS2R_1200x1200

                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS2B_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS2B_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS2R_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS2R_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS2B_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS2B_1200x1200

                End If

            ElseIf bottomEmpty = False Then
                If bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyBottom1Brown_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyBottom1Grey_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyBottom2Brown_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyBottom2Grey_1200x1200
                End If

            ElseIf shoeEmpty = False Then
                If shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyShoe1Black_1200x1200
                ElseIf shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyShoe1White_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyShoe2Red_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1Grey_1200x1200
            End If
            topEmpty = False
        ElseIf categorySelect = "bottom" Then
            cOption1.Image = Group_Testing.My.Resources.Resources.cbottom1Grey_1200x1200
            bottomSelected = "bottom1"
            bottomColor = "Grey"
            If topEmpty = False And shoeEmpty = False Then
                If topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS1B_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS1W_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS1W_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS1W_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS1W_1200x1200


                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS2R_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS2B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS2B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS2B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS2B_1200x1200
                End If


            ElseIf topEmpty = False Then
                If topSelected = "top1" And topColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom1Grey_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyBottom1Grey_1200x1200
                ElseIf topSelected = "top2" And topColor = "Blue" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom1Grey_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyBottom1Grey_1200x1200
                End If


            ElseIf shoeEmpty = False Then
                If shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1GreyShoe1Black_1200x1200
                ElseIf shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1GreyShoe1White_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1GreyShoe2Red_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1GreyShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1Grey_1200x1200
            End If
            bottomEmpty = False

        ElseIf categorySelect = "shoe" Then
            cOption1.Image = Group_Testing.My.Resources.Resources.cshoe1White_1200x1200
            shoeSelected = "shoe1"
            shoeColor = "White"
            If topEmpty = False And bottomEmpty = False Then
                If topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS1W_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS1W_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS1W_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS1W_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS1W_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS1W_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS1W_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS1W_1200x1200


                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS1W_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS1W_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS1W_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS1W_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS1W_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS1W_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS1W_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS1W_1200x1200
                End If

            ElseIf topEmpty = False Then
                If topSelected = "top1" And topColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe1White_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyShoe1White_1200x1200
                ElseIf topSelected = "top2" And topColor = "Blue" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe1White_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyShoe1White_1200x1200
                End If

            ElseIf bottomEmpty = False Then
                If bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe1White_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1GreyShoe1White_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe1White_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2GreyShoe1White_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Shoe1White_1200x1200
            End If

            shoeEmpty = False
        End If
    End Sub

    Private Sub option2Color1_Click(sender As Object, e As EventArgs) Handles option2Color1.Click
        If categorySelect = "top" Then
            cOption2.Image = Group_Testing.My.Resources.Resources.ctop2Blue_1200x1200
            topSelected = "top2"
            topColor = "Blue"
            If bottomEmpty = False And shoeEmpty = False Then
                'Insert the combo version with bottom and shoe
                If bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS1B_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS1B_1200x1200

                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS1W_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS1W_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS1B_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS1B_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS1W_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS1W_1200x1200


                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS2R_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS2R_1200x1200

                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS2B_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS2B_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS2R_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS2R_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS2B_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS2B_1200x1200
                End If

            ElseIf bottomEmpty = False Then
                If bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom1Brown_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom1Grey_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom2Brown_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom2Grey_1200x1200
                End If

            ElseIf shoeEmpty = False Then
                If shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe1Black_1200x1200
                ElseIf shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe1White_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe2Red_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2Blue_1200x1200
            End If
            topEmpty = False

        ElseIf categorySelect = "bottom" Then
            cOption2.Image = Group_Testing.My.Resources.Resources.cbottom2Brown_1200x1200
            bottomSelected = "bottom2"
            bottomColor = "Brown"
            If topEmpty = False And shoeEmpty = False Then
                If topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS1B_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS1W_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS1W_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS1W_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS1W_1200x1200


                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS2R_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS2B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS2B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS2B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS2B_1200x1200
                End If


            ElseIf topEmpty = False Then
                If topSelected = "top1" And topColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom2Brown_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyBottom2Brown_1200x1200
                ElseIf topSelected = "top2" And topColor = "Blue" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom2Brown_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyBottom2Brown_1200x1200
                End If


            ElseIf shoeEmpty = False Then
                If shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe1Black_1200x1200
                ElseIf shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe1White_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe2Red_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2Brown_1200x1200
            End If
            bottomEmpty = False

        ElseIf categorySelect = "shoe" Then
            cOption2.Image = Group_Testing.My.Resources.Resources.cshoe2Red_1200x1200
            shoeSelected = "shoe2"
            shoeColor = "Red"
            If topEmpty = False And bottomEmpty = False Then
                If topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS2R_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS2R_1200x1200


                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS2R_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS2R_1200x1200
                End If

            ElseIf topEmpty = False Then
                If topSelected = "top1" And topColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe2Red_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyShoe2Red_1200x1200
                ElseIf topSelected = "top2" And topColor = "Blue" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe2Red_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyShoe2Red_1200x1200
                End If

            ElseIf bottomEmpty = False Then
                If bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe2Red_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1GreyShoe2Red_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe2Red_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2GreyShoe2Red_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Shoe2Red_1200x1200
            End If

            shoeEmpty = False
        End If
    End Sub

    Private Sub option2Color2_Click(sender As Object, e As EventArgs) Handles option2Color2.Click
        If categorySelect = "top" Then
            cOption2.Image = Group_Testing.My.Resources.Resources.ctop2Grey_1200x1200
            topSelected = "top2"
            topColor = "Grey"
            If bottomEmpty = False And shoeEmpty = False Then
                'Insert the combo version with bottom and shoe
                If bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS1B_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS1B_1200x1200

                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS1W_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS1W_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS1B_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS1B_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS1W_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS1W_1200x1200


                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS2R_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS2R_1200x1200

                ElseIf bottomSelected = "bottom1" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS2B_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS2B_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS2R_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS2R_1200x1200

                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS2B_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS2B_1200x1200
                End If

            ElseIf bottomEmpty = False Then
                If bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyBottom1Brown_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyBottom1Grey_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyBottom2Brown_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyBottom2Grey_1200x1200
                End If

            ElseIf shoeEmpty = False Then
                If shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyShoe1Black_1200x1200
                ElseIf shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyShoe1White_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyShoe2Red_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2Grey_1200x1200
            End If
            topEmpty = False

        ElseIf categorySelect = "bottom" Then
            cOption2.Image = Group_Testing.My.Resources.Resources.cbottom2Grey_1200x1200
            bottomSelected = "bottom2"
            bottomColor = "Grey"
            If topEmpty = False And shoeEmpty = False Then
                If topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS1B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS1B_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS1W_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS1W_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS1B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS1B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS1W_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS1W_1200x1200


                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS2R_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS2R_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS2B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS2B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS2R_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS2R_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS2B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS2B_1200x1200
                End If


            ElseIf topEmpty = False Then
                If topSelected = "top1" And topColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedBottom2Grey_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyBottom2Grey_1200x1200
                ElseIf topSelected = "top2" And topColor = "Blue" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueBottom2Grey_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyBottom2Grey_1200x1200
                End If


            ElseIf shoeEmpty = False Then
                If shoeSelected = "shoe1" And shoeColor = "Black" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2GreyShoe1Black_1200x1200
                ElseIf shoeSelected = "shoe1" And shoeColor = "White" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2GreyShoe1White_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2GreyShoe2Red_1200x1200
                ElseIf shoeSelected = "shoe2" And shoeColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2GreyShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2Grey_1200x1200
            End If
            bottomEmpty = False

        ElseIf categorySelect = "shoe" Then
            cOption2.Image = Group_Testing.My.Resources.Resources.cshoe2Brown_1200x1200
            shoeSelected = "shoe2"
            shoeColor = "Brown"
            If topEmpty = False And bottomEmpty = False Then
                If topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1BrownS2B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1BrownS2B_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom1GreyS2B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom1GreyS2B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1BrownS2B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1BrownS2B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom1GreyS2B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom1GreyS2B_1200x1200


                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2BrownS2B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2BrownS2B_1200x1200

                ElseIf topSelected = "top1" And topColor = "Red" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1RBottom2GreyS2B_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T1GBottom2GreyS2B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2BrownS2B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2BrownS2B_1200x1200

                ElseIf topSelected = "top2" And topColor = "Blue" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2BBottom2GreyS2B_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" And bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.T2GBottom2GreyS2B_1200x1200
                End If

            ElseIf topEmpty = False Then
                If topSelected = "top1" And topColor = "Red" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1RedShoe2Brown_1200x1200
                ElseIf topSelected = "top1" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top1GreyShoe2Brown_1200x1200
                ElseIf topSelected = "top2" And topColor = "Blue" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2BlueShoe2Brown_1200x1200
                ElseIf topSelected = "top2" And topColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Top2GreyShoe2Brown_1200x1200
                End If

            ElseIf bottomEmpty = False Then
                If bottomSelected = "bottom1" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1BrownShoe2Brown_1200x1200
                ElseIf bottomSelected = "bottom1" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom1GreyShoe2Brown_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Brown" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2BrownShoe2Brown_1200x1200
                ElseIf bottomSelected = "bottom2" And bottomColor = "Grey" Then
                    cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Bottom2GreyShoe2Brown_1200x1200
                End If
            Else
                'Insert only version
                cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.Shoe2Brown_1200x1200
            End If

            shoeEmpty = False
        End If
    End Sub


    Public publicMannequin
    Public publicClothImage As Boolean = False
    Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim ans As DialogResult = MessageBox.Show("Do you want to save this as profile?", "Alert", MessageBoxButtons.YesNo)

        If (ans = DialogResult.Yes) Then
            publicMannequin = cDisplayMannequin.Image
            publicClothImage = True

            MessageBox.Show("Save Successfully to Profile", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub btn_Logo_Click(sender As Object, e As EventArgs) Handles btn_Logo.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Clothing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    'Private Sub Clothing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    If publicClothImage = False Then
    '        cDisplayMannequin.Image = Group_Testing.My.Resources.Resources.mannequin_1200x1200
    '        El
    '    End If

    'End Sub

End Class