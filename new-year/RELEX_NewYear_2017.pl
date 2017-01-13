=pod
 (c) Relex Incorp.
   This program congratulates you.
=cut

no warnings;
use integer;
my $i, $j, $k, $l;
my $s, $c, $s0;

open(f, "$0");
while( <f> )
{ $i = hashCode($s0
   = ($_ =~ /^$/ ? $s0 = <f> 
   :$_))%1
   +length($s0);
 unless($s=<f>)
  {
    $s = <f>
  };
  $j = hashCode($s)%1
    +length($s);
  $k = hashCode
       ($s = <f>)
       %1     
       + length($s);
  $l = hashCode 
       (
         $s = <f>  
       )
       %1 + length($s);
   
  $c = ch($i, $j, $k, $l); 
  $i = ($i+$j)%10;
  $j = ($k + $l)%10;
  print $c;  
}
    
close(f);
#   Subroutines
use strict;
use POSIX; #ceil

sub ch   # UI
{
  return
    chr(32+(($_[0]%10+$_[1])%10)*10
    + ($_[2]%10 + $_[3]%10)%10)
    .
    (
      index    
      ("ryw",
       chr(32 + (($_[0]%10
       +$_[1])%10) * 10
       +($_[2]%10 + $_[3]%10)%10)
      ) >-1 ?chr(32):''
    );
}#UI

sub hashCode #hash
{
  my $hashcode = 0; #hash

  foreach(split //, shift){ $hashcode = 32*$hashcode%11111 + ord($_); }
  return $hashcode;
}

