using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Orbeetle : Pokemon
	{
		public override string Name => "Orbeetle";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Frisk() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(60, 45, 110, 80, 120, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Reflect(), new Lightscreen(), new Confusion(), new Strugglebug() },
			[4] = new List<Move>() { new Confuseray() },
			[8] = new List<Move>() { new Magiccoat() },
			[12] = new List<Move>() { new Agility() },
			[16] = new List<Move>() { new Psybeam() },
			[20] = new List<Move>() { new Hypnosis() },
			[24] = new List<Move>() { new Allyswitch() },
			[28] = new List<Move>() { new Bugbuzz() },
			[32] = new List<Move>() { new Mirrorcoat() },
			[36] = new List<Move>() { new Psychic() },
			[40] = new List<Move>() { new Afteryou() },
			[44] = new List<Move>() { new Calmmind() },
			[48] = new List<Move>() { new Psychicterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Allyswitch(), new Attract(), new Batonpass(), new Bodypress(), new Bugbuzz(), new Calmmind(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Futuresight(), new Gigadrain(), new Gigaimpact(), new Guardswap(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Irondefense(), new Leechlife(), new Lightscreen(), new Magicroom(), new Payback(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psychocut(), new Psyshock(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Storedpower(), new Substitute(), new Trick(), new Trickroom(), new Uturn(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 408;
		public override int ExpYield => 253;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}