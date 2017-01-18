public class Name
{
    private String first;
    private String second;
    private String last;

    
    public Name(String first, String last)
    {
        this.first = first;
        this.last = last;
    }
    
   
    public Name(String first, String second, String last)
    {
        this.first = first;
        this.second = second;
        this.last = last;
    }

   
    public String getFirst()
    {
        return first;
    }
    
    
    public String getSecond()
    {
      return second;           
    }
    
    
    public String getLast()
    {
        return last;
    }
    
        public String toString()
    {
        String name = "";
        if ( first != null )
        {
           name = name + first;
        }
        if ( second != null )
        {
           name = name + " " + second;
        }
        if ( last != null )
        {
           name = name + " " + last;
        }
        return name;
    }
    
    public void setFirst( String first )
    {
       this.first = first;
    }
    
    public void setSecond( String second )
    {
       this.second = second;
    }
    
    public void setLast( String last )
    {
       this.last = last;
    }
    
    public void setFullName(String first, String last)
    {
       setFirst(first);
       setLast(last);        
    }
    
    public void setFullName(String first, String second, String last)
    {
       setFirst(first);
       setSecond(second);
       setLast(last);        
    }
    
    public boolean equals( Object o) 
    {     
        if ( o == null)  
        {
            return false;      
        }
        
        if ( this == o)
        {
            return true;   
        }
         
        Name other = (Name) o;        
         
        if (other.toString().equals( toString()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
  } 
