#!/usr/bin/python

import pygame
from pygame.locals import *
from sys import exit
from random import *

SCREEN_DEFAULT_SIZE = (800, 500)
SCREEN_DEFAULT_COLOR = (0, 0 ,0)

screen = pygame.display.set_mode(SCREEN_DEFAULT_SIZE, 0, 32)
screen.fill(SCREEN_DEFAULT_COLOR)
pygame.mouse.set_visible(False)

while 1:
    for event in pygame.event.get():
        if event.type ==  QUIT:
            exit()
        elif event.type == KEYDOWN:
            screen.fill(SCREEN_DEFAULT_COLOR)
        else:
            c_color = (randint(0, 255), randint(0, 255), randint(0, 255))
            c_pos = (randint(0, 800), randint(0, 800))
            c_r = randint(10, 100)
            pygame.draw.circle(screen, c_color, c_pos, c_r)
    pygame.display.update()