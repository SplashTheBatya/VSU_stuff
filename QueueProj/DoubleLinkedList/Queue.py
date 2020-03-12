from DoubleLinkedList import DoubleLinkedList


class Queue:
    def __len__(self):
        return len(self.list)

    def __init__(self):
        self.list = DoubleLinkedList()

    def add(self, value: object ):
        self.list.add_first(value)

    def remove(self) -> object:
        return self.list.remove_back()

    def get_value(self) -> object:
        return self.list.get_last()


per = Queue()
per.add(123) 
per.add(1234)
print(str(per.remove()))