package com.nano.unittest.hamcrest; 

import static org.junit.Assert.*;
import static org.hamcrest.CoreMatchers.*;
import static org.hamcrest.CoreMatchers.hasItems; 
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class HamcrestTest {
	/**
     *Temel Eşleştirmeler
     * Bu eşleştiriciler, JUnit ve jMock gibi birim test çerçevelerinde kullanımlara sahiptir.
     * Kodun okunabilirliğini ve daha kısa sürede daha çok iş yapılabilirliğini arttırırlar.
     */
    @Test
    public void testTemelEslestirmeler() throws Exception {

        String text1="Sevdanur";
        String text2="GENC";
        String text3=null;
        
       // assertEquals("Sevdanur",text1);

        assertThat(text1,is(equalTo("Sevdanur")));
        assertThat(text3,is(nullValue()));
        assertThat(text1,is(notNullValue()));
        assertThat(text1,containsString("dan"));

        //or herhangi birisi olursa olumlu sonuc vericektir.
        assertThat(text1,anyOf(containsString("Sev"),containsString("an")));


    }

    /**
     * Listeler hakkında testler
     * @throws Exception
     */
    @Test
    public void testListeler() throws Exception {
        List<String> sehirler= new ArrayList<String>(Arrays.asList("Istanbul", "Ankara", "Izmir"));

        assertThat(sehirler,hasItem("Istanbul"));
        assertThat(sehirler,hasItems("Istanbul", "Izmir"));
        //and
        assertThat(sehirler,allOf( hasItems("Istanbul", "Izmir"),not(hasItem("Bursa")) ));

        //either or (ya şu olsun yada bu olsun)
        assertThat(sehirler,either( hasItems("Istanbul", "Izmir")).or(not(hasItem("Bursa"))) );

    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}
