# What are Tag Helpers?
Tag Helpers enable server-side code to participate in creating and rendering HTML elements in Razor files.

# Usage
### Phone 
```
<phone call-to="177 - 777 33 33" icon="true" />
```
Result (HTML):
```
<i class="fa fa-phone">&nbsp;</i> <a href="callto:1777773333">177 - 777 33 33</a>
```
---
### Email 
```
<email mail-to="mail@example.com" icon="true"></email>
```
Result (HTML):
```
<i class="fa fa-envelope-o">&nbsp;</i> <a href="mailto:mail@example.com">mail@example.com</a>
```
---
### if statement (Exclude element)
```
<p exclude-if="1 == null">Show text</p>
```
Result (HTML):
```
<p>Show text</p>
```
---
### Active class
```
<a class="nav-link" active-when="Home/Index" asp-controller="Home" asp-action="Index">Home</a>
```
Result (HTML):
```
<a class="nav-link active" href="/Home">Home</a>
```
