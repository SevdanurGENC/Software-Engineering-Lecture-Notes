package com.nano.unittest.assertj;

import lombok.AllArgsConstructor;
import lombok.Data;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

import static org.assertj.core.api.Assertions.*;

public class CustomerListTest {
	@Test
    public void testListeler() throws Exception {

        List<Item> items= new ArrayList<Item>();
        items.add(new Item(1,"john"));
        items.add(new Item(2,"jennifer"));
        items.add(new Item(3,"jennifer"));
        items.add(new Item(4,"marc"));
        items.add(new Item(5,"marc"));

        // her name listesi icerisinde isimleri arattiriyoruz.
        assertThat(items)
                .extracting("name")
                .contains("john","marc");

        //contains icin tuple metodu ile paremetreleri kontrol ediyoruz.
        assertThat(items)
                .extracting("name","id")
                .contains(
                        tuple("john",1),
                        tuple("marc",5)
                );

        assertThat(
                	extractProperty("id",Integer.class).from(items)
                )
                .containsExactly(1,2,3,4,5);

    }

    @Data
    @AllArgsConstructor
    static class Item {
        private Integer id;
        private String name;
    }
}
