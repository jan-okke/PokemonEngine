using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kommoo : Pokemon
	{
		public override string Name => "Kommo-o";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Bulletproof(), new Abilities.Soundproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
		public override Stats BaseStats => new Stats(75, 110, 125, 100, 105, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Clangingscales() },
			[1] = new List<Move>() { new Moves.Clangingscales(), new Moves.Bellydrum(), new Moves.Autotomize(), new Moves.Tackle(), new Moves.Leer(), new Moves.Protect(), new Moves.Dragontail() },
			[12] = new List<Move>() { new Moves.Scaryface() },
			[16] = new List<Move>() { new Moves.Headbutt() },
			[20] = new List<Move>() { new Moves.Workup() },
			[24] = new List<Move>() { new Moves.Screech() },
			[28] = new List<Move>() { new Moves.Irondefense() },
			[32] = new List<Move>() { new Moves.Dragonclaw() },
			[38] = new List<Move>() { new Moves.Nobleroar() },
			[44] = new List<Move>() { new Moves.Dragondance() },
			[52] = new List<Move>() { new Moves.Outrage() },
			[60] = new List<Move>() { new Moves.Closecombat() },
			[68] = new List<Move>() { new Moves.Clangoroussoul() },
			[76] = new List<Move>() { new Moves.Boomburst() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Aurasphere(), new Moves.Bodypress(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icepunch(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Workup(), new Moves.Xscissor() };
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