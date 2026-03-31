package com.nano.unittest.assertj;

import lombok.*;

//Sadece dependency eklemekle çalışmaz. Lombok için pluginde ekleniyor
// https://projectlombok.org/p2 ile install new software deniliyor.

//@Getter
//@Setter
//@ToString bunların hepsini kapsayan @Data
@Data
@AllArgsConstructor//bütün degiskenlerin kullanildigi constructor olustu.
@NoArgsConstructor //parametresiz constructor
@Builder //yeni bir builder sinifi ve metodlari olusturuluyor.
public class Gift {

  private String name;


}
