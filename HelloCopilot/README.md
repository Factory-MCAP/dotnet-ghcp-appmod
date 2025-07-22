<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    Script</p>
<p>
    &nbsp;</p>
<p>
    /* Function to randomly assign 4 digit codes to N x M matrix representing lockers */</p>
<p>
    &nbsp;</p>
<p>
    In Main()</p>
<p>
    // Assign locker codes to a 2x2 matrix</p>
<p>
    public static int assignLockerCodes(int N, int M)</p>
<p>
&nbsp;{ Random random = new Random(); int[,] lockerCodes = new int[N, M]; for (int i = 0; i &lt; N; i++) { for (int j = 0; j &lt; M; j++) { lockerCodes[i, j] = random.Next(1000, 9999); } } return lockerCodes[0, 0]; }</p>
