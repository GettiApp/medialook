#include <iostream>
#include <cstdlib>
int main() {
    std::ofstream output;
    output.open("views.txt", std::ofstream::app);
    output << "Views: 0"; 
    output.close();
    output.open("views.txt", std::ofstream::app);
    std::int64_t views = 0;
    output << "Views: " << views << std::endl;
    return 0;
}
