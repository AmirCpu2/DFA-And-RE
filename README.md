<link href='https://fonts.googleapis.com/css?family=Oswald' rel='stylesheet' type='text/css'>

<div lang="fa" dir="rtl" style="font-family: 'Oswald', sans-serif;">
    <h1  align="center">
        وارد کردن ماشین DFA و عبارت منظم
    </h1>
   
    <p>
        <strong>
            توضیحات:
        </strong>
    </p>

    <p>
        <strong>
            برنامه شامل دو بخش می‌باشد:
        </strong>
    </p>

    <p>
        <ul>
            <li>
                <strong>دریافت ماشین DFA : </strong>
                که تمام شرایط یک ماشین DFA بررسی می‌شود.

            </li>
            <li>
                <strong>  وارد کردن عبارت منظم : </strong>
                که برنامه مشخص می‌کند این عبارت منظم عضو این زبان است یا خیر.
            </li>
        </ul>
    </p>

    <p>
        <h2>
            _ دریافت ماشین DFA :
        </h2>
        ماشین DFA سه شرط دارد که باید حتما رعایت شود در غیر این صورت آن ماشین NFA می‌باشد.
        <ol>
            <li>
                با خواند یک ورودی فقط بتوانیم به یک حالت برویم
            </li>
            <li>
                بدون خواندن یک ورودی نتوانیم به حالت دیگری برویم
            </li>
            <li>
                به تعداد حروف الفبای مان باید مشخص شود با خواند ورودی به کدام حالت برویم
            </li>
        </ol>
    </p>
    <p>
        در مثال های زیر مشاهده می‌کنید که چگونه شروط یک ماشین DFA بررسی می‌شود.
    </p>

    <p align="center">
        <div  align="right">
            <strong>
                مثال اول :
            </strong>
        </div>
        <strong>
            <img src="http://www.mediafire.com/convkey/1875/x6kn9z1501h54i5zg.jpg" border="0" alt="image1" style="width:100%" />
        </strong>

         <div  align="right">
            <strong>
                مثال دوم :
            </strong>
        </div>

        <img src="http://www.mediafire.com/convkey/0ad7/q88lg4whdtxhz86zg.jpg" border="0" alt="image1" style="width:100%" />
    </p>

    <p>
        <h2>
            _ دریافت ماشین DFA :
        </h2>
        با وارد کردن عبارت منظم و زدن دکمه "خواند رشته" (Read String) اگر ماشین وارد شده DFA باشد تابع
        <a href="https://github.com/abnnajaf/DFA-And-RE/blob/master/Enter_DFA_Machine/Form1.cs#L183" target="_blank">
            ()ReadString
        </a>

        فراخوانی می‌شود. و اگر ماشین DFA نباشد پیام مناسبی چاپ می‌شود.
    </p>
</div>
