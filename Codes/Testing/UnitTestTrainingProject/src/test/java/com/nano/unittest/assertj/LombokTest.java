package com.nano.unittest.assertj;

import org.junit.Test; 

public class LombokTest {
	
	//lombok : compile asamasinda get,set, constructor gibi methodlar ekliypr 
	
	@Test
    public void testLombok() throws Exception {

        Gift gift = new Gift("Sevdanur");
        System.out.println(gift.toString());
        

    }

    @Test
    public void testLombokBuilder() throws Exception {

        GiftBuilder gift= GiftBuilder.builder().name("Sevdanur").surname("GENC").build();
        System.out.println(gift.toString());

    }
}
