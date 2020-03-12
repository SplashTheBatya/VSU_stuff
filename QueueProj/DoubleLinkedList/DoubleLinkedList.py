

class DoubleLinkedList:

    class Node:
        def __init__(self, data: object, prev=None, next=None):
            self.data = data
            self.prev = prev
            self.next = next

    def __init__(self):
        self.length = 0
        self.head_ptr = self.Node(0)
        self.tail_ptr = self.Node(0) 
        pass   

    def __len__(self):
        return self.length

    # def __index__(self):
    #     return self.index_of(self)

    # def __next__(self):
    #     pass

    def get_enumerator(self):
        temp = self.head_ptr
        while(temp.next != None):
            yield temp.data
            temp = temp.next
        yield temp.data

    # def insert(self, value: object, index: int):
    #     raise NotImplementedError

    # def index_of(self, value: object) -> int:
    #     raise NotImplementedError

    # def get_by_index(self, index: int):
    #     raise NotImplementedError

    # def remove_by_index(self, index: int):
    #     raise NotImplementedError

    # def remove(self, value: object):
    #     raise NotImplementedError


    def __str__(self):
        if self.head_ptr != None:
            current = self.head_ptr
            out = 'DoubleLinkedList [\n' +str(current.data) +'\n'
            while current.next != None:
                current = current.next
                out += str(current.data) + '\n'
            return out + ']'
        return 'DoubleLinkedList []'

    def clear(self):
        self.__init__()


    def add_last(self, data: object) -> None:
        self.length += 1
        if self.length == 0:
            self.head_ptr = self.tail_ptr = self.Node(data)
        else:
            self.tail_ptr = self.Node(data, self.tail_ptr)
            self.tail_ptr.prev.next = self.tail_ptr


    def add_first(self, data: object) -> None:
        self.length += 1
        if self.head_ptr == None:
            self.tail_ptr = self.head_ptr = self.Node(data)
        else:
            self.head_ptr = self.Node(data, None, self.head_ptr)
            self.head_ptr.next.prev = self.head_ptr


    def remove_first(self) -> object:
        if self.length == 0:
            raise IndexError('Пощёл в пизду')
        else:
            removed_value = self.head_ptr.data
            self.head_ptr = self.head_ptr.next
            self.head_ptr.prev = None
            self.length -= 1
            return removed_value
    
    def Del(self,i):
        if (self.first == None):
          return
        curr = self.first
        count = 0
        if i == 0:
          self.first = self.first.next
          return
        while curr != None:
            if count == i:
              if curr.next == None:
                self.last = curr
              old.next = curr.next 
              break
            old = curr  
            curr = curr.next
            count += 1

    def remove_back(self) -> object:
        if self.length == 0:
            raise IndexError('Пощёл в пизду')
        elif self.length == 1:
            removed_value = self.tail_ptr.data
            self.tail_ptr = self.head_ptr = None
            self.length -= 1
        else:
            removed_value = self.tail_ptr.data
            self.tail_ptr = self.tail_ptr.prev
            self.tail_ptr.next = self.Node(0)
            self.length -= 1
            return removed_value

    def get_first(self) -> object:
        if self.length == 0:
            raise IndexError('Пощёл в пизду')
        else:
            return self.head_ptr.data

    def get_last(self) -> object:
        if self.length == 0:
            raise IndexError('Пощёл в пизду')
        else:
            return self.tail_ptr.data