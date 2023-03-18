using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kommo-o : Pokemon
	{
		public override string Name => "Kommo-o";
		public override List<Ability> AvailableAbilities => new() {new Bulletproof(), new Soundproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(75, 110, 125, 85, 100, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Clangingscales() },
			[1] = new List<Move>() { new Clangingscales(), new Bellydrum(), new Autotomize(), new Tackle(), new Leer(), new Protect(), new Dragontail() },
			[12] = new List<Move>() { new Scaryface() },
			[16] = new List<Move>() { new Headbutt() },
			[20] = new List<Move>() { new Workup() },
			[24] = new List<Move>() { new Screech() },
			[28] = new List<Move>() { new Irondefense() },
			[32] = new List<Move>() { new Dragonclaw() },
			[38] = new List<Move>() { new Nobleroar() },
			[44] = new List<Move>() { new Dragondance() },
			[52] = new List<Move>() { new Outrage() },
			[60] = new List<Move>() { new Closecombat() },
			[68] = new List<Move>() { new Clangoroussoul() },
			[76] = new List<Move>() { new Boomburst() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Aurasphere(), new Bodypress(), new Breakingswipe(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Drainpunch(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Firepunch(), new Flamethrower(), new Flashcannon(), new Fling(), new Focusblast(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icepunch(), new Irondefense(), new Ironhead(), new Irontail(), new Lowkick(), new Megakick(), new Megapunch(), new Outrage(), new Payback(), new Poisonjab(), new Protect(), new Rest(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Scaleshot(), new Scaryface(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Substitute(), new Superpower(), new Swordsdance(), new Taunt(), new Thunderpunch(), new Uproar(), new Workup(), new Xscissor() };
		public override int Weight => 782;
		public override int ExpYield => 300;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 3,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}