using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Beedrill : Pokemon
	{
		public override string Name => "Beedrill";
		public override List<Ability> AvailableAbilities => new() {new Swarm() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sniper() };
		public override Stats BaseStats => new Stats(65, 90, 40, 75, 45, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Furyattack() },
			[1] = new List<Move>() { new Bugbite(), new Furyattack() },
			[11] = new List<Move>() { new Furycutter() },
			[14] = new List<Move>() { new Laserfocus() },
			[17] = new List<Move>() { new Poisonsting() },
			[20] = new List<Move>() { new Focusenergy() },
			[23] = new List<Move>() { new Venoshock() },
			[26] = new List<Move>() { new Assurance() },
			[29] = new List<Move>() { new Toxicspikes() },
			[32] = new List<Move>() { new Pinmissile() },
			[35] = new List<Move>() { new Poisonjab() },
			[38] = new List<Move>() { new Agility() },
			[41] = new List<Move>() { new Endeavor() },
			[44] = new List<Move>() { new Fellstinger() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Brickbreak(), new Brutalswing(), new Bugbite(), new Confide(), new Cut(), new Defog(), new Doubleteam(), new Drillrun(), new Electroweb(), new Endeavor(), new Endure(), new Facade(), new Falseswipe(), new Flash(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Infestation(), new Knockoff(), new Laserfocus(), new Payback(), new Poisonjab(), new Protect(), new Rest(), new Return(), new Rocksmash(), new Roost(), new Round(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Tailwind(), new Thief(), new Throatchop(), new Uturn(), new Venoshock(), new Xscissor() };
		public override int Weight => 295;
		public override int ExpYield => 198;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}