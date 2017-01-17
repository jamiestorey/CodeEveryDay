/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.zaqqaz130.critter;

import java.util.ArrayList;

/**
 *
 * @author zaqqaz130
 */
public class Cake {
    
    public void mmmCake() {
        Animal dog = new Dog();
        Animal cat = new Cat();
        Animal wolf = new Wolf();
        Animal beast = new Animal();
        
        ArrayList<Animal> animals = new ArrayList<>();
        
        animals.add(cat);
        animals.add(dog);
        animals.add(wolf);
        animals.add(beast);
        
        for (Animal temp : animals) {
            temp.MakeNoise();
        }
    }
    
}
